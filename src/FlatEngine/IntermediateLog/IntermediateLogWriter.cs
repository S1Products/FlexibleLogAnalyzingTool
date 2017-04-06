#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Reflection;

using System.Data.SQLite;

namespace FlatEngine.IntermediateLog
{
    /// <summary>
    /// Write log lines to database
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class IntermediateLogWriter : IDisposable
    {
        /// <summary>
        /// Suffix of table index name
        /// </summary>
        public const string IDX_SUFFIX = "_IDX";

        private Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Log line parser regex
        /// </summary>
        private Regex regex;

        /// <summary>
        /// Analyzing pattern column settings
        /// </summary>
        private ColumnDefinitionList columnDefList;

        /// <summary>
        /// Writed line count
        /// </summary>
        private int lineCount = 0;

        /// <summary>
        /// Connection for database
        /// </summary>
        private SQLiteConnection connection;

        /// <summary>
        /// Writed line count
        /// </summary>
        public int LineCount
        {
            get
            {
                return lineCount;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileName">Database file name</param>
        /// <param name="patternDef">Analyzing pattern</param>
        public IntermediateLogWriter(string fileName, PatternDefinition patternDef)
        {
            log.In(fileName, patternDef);

            this.regex = new Regex(patternDef.RegularExpression);
            this.columnDefList = patternDef.ColumnDefinitionList;

            if (File.Exists(fileName) == false)
            {
                CreateDB(fileName, patternDef.ColumnDefinitionList);
            }

            connection = SQLiteUtil.OpenConnection(fileName);

            log.Out();
        }

        /// <summary>
        /// Dispose object with close database connection.
        /// You can use "using" statement.
        /// Auto close internal connection without call Close method.
        /// </summary>
        public void Dispose()
        {
            log.In();

            connection.Close();

            log.Out();
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void Close()
        {
            log.In();

            connection.Close();

            log.Out();
        }

        /// <summary>
        /// Write analyzed log to internal database
        /// </summary>
        /// <param name="fileName">Log file name</param>
        /// <param name="logStream">Stream of log file</param>
        /// <param name="enc">Log file encoding</param>
        public void Write(string fileName, Stream logStream, Encoding enc)
        {
            log.In(logStream);

            // Reset line count
            lineCount = 0;

            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                StreamReader reader = new StreamReader(new BufferedStream(logStream), enc);

                FileValue file = InsertFileName(fileName);

                ParsedLogLine prevParsedLog = null;

                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    ParsedLogLine logLine = ParseLine(file, line, regex, columnDefList);
                    if(logLine != null)
                    {
                        // If log line has error then set previous datetime value for sorting
                        if (logLine.HasError)
                        {
                            ParsedLogColumn col = GetDateTimeColumn(prevParsedLog);

                            if (col != null)
                            {
                                logLine.ColumnList.Add(col);
                            }
                        }
                        else
                        {
                            prevParsedLog = logLine;
                        }

                        lineCount++;
                        logLine.LineNumber = lineCount;
                        InsertLogLine(logLine);
                    }
                }

                trans.Commit();
            }

            log.Out();
        }

        /// <summary>
        /// Find and get DateTime column from parsed log line
        /// </summary>
        /// <param name="logLine">Parsed log line</param>
        /// <returns>DateTime log column</returns>
        private ParsedLogColumn GetDateTimeColumn(ParsedLogLine logLine)
        {
            if (logLine == null)
            {
                return null;
            }

            foreach (ParsedLogColumn col in logLine.ColumnList)
            {
                if (col.ColumnDefinition.IsDateTimeField)
                {
                    return col;
                }
            }

            return null;
        }

        #region "Database processing"

        #region "Create tables"

        /// <summary>
        /// Create database file 
        /// </summary>
        /// <param name="fileName">Database file name</param>
        /// <param name="colDefList">Column definition list</param>
        private void CreateDB(string fileName, ColumnDefinitionList colDefList)
        {
            log.InPrivate();

            SQLiteConnection.CreateFile(fileName);
            using (SQLiteConnection initCon = SQLiteUtil.OpenConnection(fileName))
            {
                using(SQLiteCommand com = initCon.CreateCommand())
                {
                    CreateHashedValueTable(com);

                    CreateLogFileTable(com);

                    CreateParsedLogTable(com, colDefList);
                }
            }

            log.OutPrivate();
        }

        /// <summary>
        /// Create HashedValue table
        /// </summary>
        /// <param name="com">Command</param>
        private void CreateHashedValueTable(SQLiteCommand com)
        {
            log.InPrivate(com);

            com.CommandText
                = "create table " + IntermediateLogConstants.TABLE_NAME_HASHED_VALUES
                    + "(" + IntermediateLogConstants.COL_NAME_HV_ID + " integer primary key autoincrement, " 
                    + IntermediateLogConstants.COL_NAME_HV_VALUE + " text)";

            com.ExecuteNonQuery();


            com.CommandText
                = "create index " + IntermediateLogConstants.INDEX_NAME_HASHED_VALUES
                    + " on " + IntermediateLogConstants.TABLE_NAME_HASHED_VALUES 
                    + "(" + IntermediateLogConstants.COL_NAME_HV_VALUE + ")";

            com.ExecuteNonQuery();

            log.OutPrivate();
        }

        /// <summary>
        /// Create LogFile table
        /// </summary>
        /// <param name="com">Command</param>
        private void CreateLogFileTable(SQLiteCommand com)
        {
            log.InPrivate(com);

            com.CommandText
                = "create table " + IntermediateLogConstants.TABLE_NAME_LOG_FILES
                    + "(" + IntermediateLogConstants.COL_NAME_LF_ID + " integer primary key autoincrement, "
                    + IntermediateLogConstants.COL_NAME_LF_FILE_NAME + " text)";

            com.ExecuteNonQuery();


            com.CommandText
                = "create index " + IntermediateLogConstants.INDEX_NAME_LOG_FILES
                    + " on " + IntermediateLogConstants.TABLE_NAME_LOG_FILES
                    + "(" + IntermediateLogConstants.COL_NAME_LF_FILE_NAME + ")";

            com.ExecuteNonQuery();


            log.OutPrivate();
        }

        /// <summary>
        /// Create ParsedLog table
        /// </summary>
        /// <param name="com">Command</param>
        /// <param name="colDefList">Column definition list</param>
        private void CreateParsedLogTable(SQLiteCommand com, ColumnDefinitionList colDefList)
        {
            log.InPrivate(com, colDefList);

            com.CommandText
                = "create table " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS + "(";

            com.CommandText += IntermediateLogConstants.COL_NAME_PL_ID + " integer primary key autoincrement, ";
            com.CommandText += IntermediateLogConstants.COL_NAME_PL_LINE_NUM + " integer, ";
            com.CommandText += IntermediateLogConstants.COL_NAME_PL_FILE_ID + " integer, ";
            com.CommandText += IntermediateLogConstants.COL_NAME_PL_HAS_ERROR + " integer, ";
            com.CommandText += IntermediateLogConstants.COL_NAME_PL_NOT_PARSED_LINE + " text, ";

            foreach (ColumnDefinition colDef in colDefList)
            {
                com.CommandText += colDef.ColumnName;

                if (colDef.IsDateTimeField || colDef.Hashable)
                {
                    com.CommandText += " integer, ";
                }
                else
                {
                    com.CommandText += " text, ";
                }
            }

            // Remove last ", "
            com.CommandText = com.CommandText.Substring(0, com.CommandText.Length - 2);
            com.CommandText += ")";
            com.ExecuteNonQuery();

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (colDef.IsDateTimeField)
                {
                    com.CommandText
                        = "create index " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS
                            + "_" + colDef.ColumnName + IDX_SUFFIX
                            + " on " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS + "("
                            + colDef + ")";

                    com.ExecuteNonQuery();
                }
            }

            log.OutPrivate();
        }

        #endregion

        #region "FILE_NAME table"

        /// <summary>
        /// Insert file name to LogFile table
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>File value</returns>
        private FileValue InsertFileName(string fileName)
        {
            log.InPrivate(fileName);

            string truncFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

            using (SQLiteCommand comm = connection.CreateCommand())
            {

                comm.CommandText
                    = "insert into " + IntermediateLogConstants.TABLE_NAME_LOG_FILES
                        + "(" + IntermediateLogConstants.COL_NAME_LF_FILE_NAME + ") "
                        + "values(@Value)";

                comm.Parameters.Add("Value", System.Data.DbType.String);
                comm.Parameters["Value"].Value = truncFileName;

                comm.ExecuteNonQuery();
            }

            long id = GetFileID(truncFileName);

            FileValue val = new FileValue();
            val.ID = id;
            val.Name = truncFileName;

            log.OutPrivate(val);
            return val;
        }

        /// <summary>
        /// Find and get File ID from LogFile table
        /// </summary>
        /// <param name="fileName">Target file name</param>
        /// <returns>File ID. If not exist file name then return -1.</returns>
        private long GetFileID(String fileName)
        {
            log.InPrivate(fileName);

            using (SQLiteCommand comm = connection.CreateCommand())
            {
                comm.CommandText
                    = "select * from " + IntermediateLogConstants.TABLE_NAME_LOG_FILES
                        + " where " + IntermediateLogConstants.COL_NAME_LF_FILE_NAME + "= @Value";

                comm.Parameters.Add("Value", System.Data.DbType.String);
                comm.Parameters["Value"].Value = fileName;

                using (SQLiteDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        long val = (long)reader[IntermediateLogConstants.COL_NAME_HV_ID];

                        log.OutPrivate(val);
                        return val;
                    }
                    else
                    {
                        log.OutPrivate(-1);
                        return -1;
                    }
                }
            }
        }

        #endregion

        #region "HASHED_VALUE table"

        /// <summary>
        /// Insert HashedValue table
        /// </summary>
        /// <param name="lineElem">Hashed target column value</param>
        /// <returns>HashedValue ID</returns>
        private long InsertHashedValue(string lineElem)
        {
            log.InPrivate(lineElem);

            using (SQLiteCommand comm = connection.CreateCommand())
            {
                comm.CommandText
                    = "insert into " + IntermediateLogConstants.TABLE_NAME_HASHED_VALUES
                        + "(" + IntermediateLogConstants.COL_NAME_HV_VALUE + ") "
                        + "values(@Value)";

                comm.Parameters.Add("Value", System.Data.DbType.String);
                comm.Parameters["Value"].Value = lineElem;

                comm.ExecuteNonQuery();
            }

            long val = GetHashedValueID(lineElem);

            log.OutPrivate(val);
            return val;
        }

        /// <summary>
        /// Find and get Hashed Value ID from HashedValue table
        /// </summary>
        /// <param name="lineElem">Target column value</param>
        /// <returns>HashedValue ID. If not exist then return -1.</returns>
        private long GetHashedValueID(string lineElem)
        {
            log.InPrivate(lineElem);

            using (SQLiteCommand comm = connection.CreateCommand())
            {
                comm.CommandText
                    = "select * from " + IntermediateLogConstants.TABLE_NAME_HASHED_VALUES
                        + " where " + IntermediateLogConstants.COL_NAME_HV_VALUE + "= @Value";

                comm.Parameters.Add("Value", System.Data.DbType.String);
                comm.Parameters["Value"].Value = lineElem;

                using (SQLiteDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        long val = (long)reader[IntermediateLogConstants.COL_NAME_HV_ID];

                        log.OutPrivate(val);
                        return val;
                    }
                    else
                    {
                        log.OutPrivate(-1);
                        return -1;
                    }
                }
            }
        }

        #endregion

        #region "PARSED_LOGS table"

        /// <summary>
        /// Insert Parsed log line to ParsedLog table
        /// </summary>
        /// <param name="logLine">Target log line</param>
        private void InsertLogLine(ParsedLogLine logLine)
        {
            log.InPrivate(logLine);

            using (SQLiteCommand comm = connection.CreateCommand())
            {
                comm.CommandText
                    = "insert into " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS
                        + "(" + CreateColumnsString(logLine) + ")";

                SetColumnValues(comm, logLine);
                comm.ExecuteNonQuery();
            }

            log.OutPrivate();
        }

        #endregion

        #endregion

        /// <summary>
        /// Parse log line
        /// </summary>
        /// <param name="file">Log file name</param>
        /// <param name="line">Target log line</param>
        /// <param name="regex">Analyzing regex</param>
        /// <param name="colDefList">Column definition list</param>
        /// <returns>Parsed log line</returns>
        private ParsedLogLine ParseLine(FileValue file, string line, Regex regex, ColumnDefinitionList colDefList)
        {
            log.InPrivate(line, regex, colDefList);

            ParsedLogLine logLine = new ParsedLogLine();
            logLine.File = file;
            logLine.ColumnList = new List<ParsedLogColumn>();

            string[] lineElems = regex.Split(line);
            lineElems = RemoveFirstAndLastEmptyElems(lineElems);

            if (lineElems.Length != colDefList.Count)
            {
                log.Warn("Log element size is different.Skip this line. Expected=" + colDefList.Count.ToString() + " Actual=" + lineElems.Length);
                logLine.HasError = true;
                logLine.NotParsedLog = line;

                log.OutPrivate(logLine);
                return logLine;
            }

            int index = 0;

            foreach (string lineElem in lineElems)
            {
                ColumnDefinition colDef = colDefList[index];

                ParsedLogColumn col = new ParsedLogColumn();
                col.ColumnDefinition = colDef;

                if (colDef.IsDateTimeField)
                {
                    if(SetDataTimeValue(lineElem, col, colDef) == false)
                    {
                        logLine.HasError = true;
                        log.Warn("Could not parse DateTime value. Value=" + lineElem);
                    }
                }
                else if (colDef.Hashable)
                {
                    SetHashedValue(lineElem, col);
                }
                else
                {
                    col.Value = lineElem;
                }

                logLine.ColumnList.Add(col);

                index++;
            }

            if (logLine.HasError || line.Trim() == "")
            {
                logLine.ColumnList.Clear();
                logLine.HasError = true;
                logLine.NotParsedLog = line;
            }

            log.OutPrivate(logLine);
            return logLine;
        }

        /// <summary>
        /// Remove first and last empty string for regex.
        /// Because .NET regex method returns empty string by regex.split method.
        /// </summary>
        /// <param name="elems">Parsed elements</param>
        /// <returns>Removed elements of empty strings</returns>
        public static string[] RemoveFirstAndLastEmptyElems(string[] elems)
        {
            List<string> elemList = new List<string>();

            for (int i = 0; i < elems.Length; i++)
            {
                if (i == 0 || i == elems.Length - 1)
                {
                    if (elems[i] == string.Empty)
                    {
                        continue;
                    }
                }

                elemList.Add(elems[i]);
            }

            return elemList.ToArray();
        }

        /// <summary>
        /// Create column name list string value for SELECT statement.
        /// </summary>
        /// <param name="logLine">Target log line</param>
        /// <returns>Column name list string</returns>
        private string CreateColumnsString(ParsedLogLine logLine)
        {
            log.InPrivate(logLine);

            string cols = IntermediateLogConstants.COL_NAME_PL_LINE_NUM + ","
                            + IntermediateLogConstants.COL_NAME_PL_FILE_ID + ","
                            + IntermediateLogConstants.COL_NAME_PL_HAS_ERROR + ","
                            + IntermediateLogConstants.COL_NAME_PL_NOT_PARSED_LINE + ",";

            foreach(ParsedLogColumn col in logLine.ColumnList)
            {
                cols += col.ColumnDefinition.ColumnName + ",";
            }

            string val = cols.Substring(0, cols.Length - 1);
            log.OutPrivate(val);
            return val;
        }

        /// <summary>
        /// Add parameters for insert column values
        /// </summary>
        /// <param name="comm">Command</param>
        /// <param name="logLine">Target log line</param>
        private void SetColumnValues(SQLiteCommand comm, ParsedLogLine logLine)
        {
            log.InPrivate(comm, logLine);

            comm.CommandText += " values(";

            comm.CommandText += "@LogLine, ";
            comm.Parameters.Add("LogLine", System.Data.DbType.Int64);
            comm.Parameters["LogLine"].Value = logLine.LineNumber;

            comm.CommandText += "@FileID, ";
            comm.Parameters.Add("FileID", System.Data.DbType.Int64);
            comm.Parameters["FileID"].Value = logLine.File.ID;

            comm.CommandText += "@HasError, ";
            comm.Parameters.Add("HasError", System.Data.DbType.Int64);
            comm.Parameters["HasError"].Value = logLine.HasError;

            comm.CommandText += "@NotParsedLog, ";
            comm.Parameters.Add("NotParsedLog", System.Data.DbType.String);
            comm.Parameters["NotParsedLog"].Value = logLine.NotParsedLog;

            foreach(ParsedLogColumn col in logLine.ColumnList)
            {
                string colName = col.ColumnDefinition.ColumnName;

                comm.CommandText += "@" + colName + ", ";

                if (col.ColumnDefinition.IsDateTimeField || col.ColumnDefinition.Hashable)
                {
                    comm.Parameters.Add(colName, System.Data.DbType.Int64);
                }
                else
                {
                    comm.Parameters.Add(colName, System.Data.DbType.String);
                }

                comm.Parameters[colName].Value = col.Value;
            }

            comm.CommandText = comm.CommandText.Substring(0, comm.CommandText.Length - 2) + ")";

            log.OutPrivate();
        }

        /// <summary>
        /// Set date time value from database string value
        /// </summary>
        /// <param name="lineElem">Raw log element value</param>
        /// <param name="col">Parsed log column without datetime value</param>
        /// <param name="colDef">Column definition</param>
        /// <returns>Parsed log column with datetime value</returns>
        private bool SetDataTimeValue(string lineElem, ParsedLogColumn col, ColumnDefinition colDef)
        {
            log.InPrivate(lineElem, col, colDef);

            DateTime date;
            if (DateTime.TryParseExact(lineElem,
                                      colDef.DateTimeFormat,
                                      System.Globalization.DateTimeFormatInfo.InvariantInfo,
                                      System.Globalization.DateTimeStyles.None,
                                      out date))
            {

                col.Value = date.Ticks.ToString();

                log.OutPrivate(true);
                return true;
            }
            else
            {
                log.OutPrivate(false);
                return false;
            }
        }

        /// <summary>
        /// Set HashedValue to Parsed log column.
        /// If not exist hashed value then insert new value to database
        /// </summary>
        /// <param name="lineElem">Raw log element value</param>
        /// <param name="col">Parsed log column</param>
        private void SetHashedValue(string lineElem, ParsedLogColumn col)
        {
            log.InPrivate(lineElem, col);

            using(SQLiteTransaction trans = connection.BeginTransaction())
            {
                long id = GetHashedValueID(lineElem);

                if (id == -1)
                {
                    id = InsertHashedValue(lineElem);
                }

                col.Value = id.ToString();

                trans.Commit();
            }

            log.OutPrivate();
        }
    }
}