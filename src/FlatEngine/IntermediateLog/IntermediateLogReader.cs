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
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

using System.Data;
using System.Data.SQLite;

using System.Linq;
using System.Linq.Expressions;

namespace FlatEngine.IntermediateLog
{
    /// <summary>
    /// Read parsed log lines from database
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class IntermediateLogReader : IDisposable
    {
        /// <summary>
        /// Suffix of hashed id column
        /// </summary>
        public const string HASHED_SUFFIX = "_HASHED";

        /// <summary>
        /// Current reader column definition list.
        /// Parsed log lines are mapped columns by this definitions.
        /// </summary>
        private ColumnDefinitionList colDefList;

        /// <summary>
        /// Database connection
        /// </summary>
        private SQLiteConnection connection;

        private Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fileName">Database file name</param>
        /// <param name="patternDef">Analyzing pattern definition</param>
        public IntermediateLogReader(String fileName, PatternDefinition patternDef)
        {
            log.In(fileName, patternDef);

            this.colDefList = patternDef.ColumnDefinitionList;

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

            SQLiteUtil.CloseConnection(connection);

            log.Out();
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void Close()
        {
            log.In();

            SQLiteUtil.CloseConnection(connection);

            log.Out();
        }

        public List<FileValue> GetAllFileValueList()
        {
            log.In();

            List<FileValue> fileValueList = new List<FileValue>();

            SQLiteCommand comm = connection.CreateCommand();
            comm.CommandText = "select * from " + IntermediateLogConstants.TABLE_NAME_LOG_FILES;

            using (SQLiteDataReader reader = comm.ExecuteReader())
            {
                while(reader.Read())
                {
                    FileValue value = new FileValue();
                    value.ID = int.Parse(reader[IntermediateLogConstants.COL_NAME_LF_ID].ToString());
                    value.Name = reader[IntermediateLogConstants.COL_NAME_LF_FILE_NAME].ToString();

                    fileValueList.Add(value);
                }
            }

            log.Out(fileValueList);

            return fileValueList;
        }

        /// <summary>
        /// Get total log lines count
        /// </summary>
        /// <returns>Total log lines count</returns>
        private int GetTotalLineCount()
        {
            log.In();

            SQLiteCommand comm = connection.CreateCommand();
            comm.CommandText = "select count(*) from " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS;

            using (SQLiteDataReader reader = comm.ExecuteReader())
            {
                reader.Read();

                int count = int.Parse(reader[0].ToString());
                log.Out(count);
                return count;
            }
        }

        /// <summary>
        /// Get log line count by specified search criteria
        /// </summary>
        /// <param name="criteria">Search conditions</param>
        /// <returns>Log line count</returns>
        private int GetLineCount(SearchCriteria criteria)
        {
            log.In(criteria);

            SQLiteCommand comm = connection.CreateCommand();
            comm.CommandText = "select count(*) from " + IntermediateLogConstants.TABLE_NAME_PARSED_LOGS;
            AddWhereClause(comm, criteria, true);

            using (SQLiteDataReader reader = comm.ExecuteReader())
            {
                reader.Read();

                int count = int.Parse(reader[0].ToString());
                log.Out(count);
                return count;
            }
        }

        /// <summary>
        /// Read log lines from database
        /// </summary>
        /// <param name="criteria">Search condition</param>
        /// <param name="colDefList">Column definition list</param>
        /// <param name="highlightDefList">Highlight definition list</param>
        /// <param name="offset">Read start position</param>
        /// <param name="limit">Read log lines limit</param>
        /// <returns>Parsed log lines</returns>
        public ParsedLog ReadLines(SearchCriteria criteria, ColumnDefinitionList colDefList,
            HighlightDefinitionList highlightDefList, int offset, int limit)
        {
            log.In(criteria, offset, limit);

            SQLiteCommand comm = connection.CreateCommand();
            SetSelectStatement(comm, colDefList, criteria, offset, limit);

            ParsedLog parsedLog = new ParsedLog();

            List<ParsedLogLine> lineList = new List<ParsedLogLine>();

            using(SQLiteDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    ParsedLogLine logLine = new ParsedLogLine();
                    logLine.File = new FileValue();
                    logLine.File.Name = GetStringValue(reader, IntermediateLogConstants.COL_NAME_LF_FILE_NAME);
                    logLine.LineNumber = GetIntValue(reader, IntermediateLogConstants.COL_NAME_PL_LINE_NUM);
                    logLine.HasError = GetBooleanValue(reader, IntermediateLogConstants.COL_NAME_PL_HAS_ERROR);
                    logLine.NotParsedLog = GetStringValue(reader, IntermediateLogConstants.COL_NAME_PL_NOT_PARSED_LINE);

                    foreach(ColumnDefinition colDef in colDefList)
                    {
                        ParsedLogColumn col = new ParsedLogColumn();
                        col.ColumnDefinition = colDef;
                        col.Value = GetStringValue(reader, colDef.ColumnName);

                        if (highlightDefList != null)
                        {
                            SetHighlights(col, highlightDefList);
                        }

                        logLine.ColumnList.Add(col);
                    }

                    lineList.Add(logLine);
                }
            }

            parsedLog.TotalLineCount = GetTotalLineCount();
            parsedLog.TargetLineCount = GetLineCount(criteria);
            parsedLog.LogLineList = lineList;

            log.Out(lineList);

            return parsedLog;
        }

        #region "Create SELECT Statement"

        /// <summary>
        /// Set select statement to command
        /// </summary>
        /// <param name="comm">Command</param>
        /// <param name="colDefList">Column definition list</param>
        /// <param name="criteria">Search condition</param>
        /// <param name="offset">Result count offset</param>
        /// <param name="limit">Result count limit</param>
        private void SetSelectStatement(SQLiteCommand comm, 
            ColumnDefinitionList colDefList, SearchCriteria criteria,
            int offset, int limit)
        {
            log.InPrivate(comm);

            StringBuilder selectSb = new StringBuilder();
            selectSb.Append("select ");
            selectSb.Append(CreatePLColumnName(IntermediateLogConstants.COL_NAME_PL_LINE_NUM));
            selectSb.Append(",");
            selectSb.Append(CreatePLColumnName(IntermediateLogConstants.COL_NAME_PL_HAS_ERROR));
            selectSb.Append(",");
            selectSb.Append(CreatePLColumnName(IntermediateLogConstants.COL_NAME_PL_NOT_PARSED_LINE));
            selectSb.Append(",");
            selectSb.Append(CreateLFColumnName(IntermediateLogConstants.COL_NAME_LF_FILE_NAME));
            selectSb.Append(",");

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (colDef.Hashable)
                {
                    selectSb.Append(CreateHVColumnNameWithAlias(colDef.ColumnName));
                    selectSb.Append(",");
                }
                else
                {
                    selectSb.Append(CreatePLColumnName(colDef.ColumnName));
                    selectSb.Append(",");
                }
            }

            //Remove last comma
            selectSb.Remove(selectSb.Length - 1, 1);
            selectSb.Append(" from ");
            selectSb.Append(IntermediateLogConstants.TABLE_NAME_PARSED_LOGS);
            selectSb.Append(",");
            selectSb.Append(IntermediateLogConstants.TABLE_NAME_LOG_FILES);

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (colDef.Hashable)
                {
                    selectSb.Append(" left join ");
                    selectSb.Append(CreateHVTableName(colDef.ColumnName));
                    selectSb.Append(" on ");
                    selectSb.Append(CreatePLColumnName(colDef.ColumnName));
                    selectSb.Append("=");
                    selectSb.Append(CreateHVColumnName(colDef.ColumnName));
                }
            }

            StringBuilder whereSb = new StringBuilder();
            whereSb.Append(" where (");
            whereSb.Append(CreatePLColumnName(IntermediateLogConstants.COL_NAME_PL_FILE_ID));
            whereSb.Append("=");
            whereSb.Append(CreateLFColumnName(IntermediateLogConstants.COL_NAME_LF_ID));
            whereSb.Append(" and ");

            //Remove last AND
            whereSb.Remove(whereSb.Length - " and ".Length, " and ".Length);
            whereSb.Append(") ");

            comm.CommandText = selectSb.ToString() + whereSb.ToString();

            AddWhereClause(comm, criteria, false);

            comm.CommandText += " order by ";

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (colDef.IsDateTimeField)
                {
                    comm.CommandText += colDef.ColumnName + " asc,";
                }
            }

            comm.CommandText += IntermediateLogConstants.COL_NAME_PL_LINE_NUM + " asc";

            comm.CommandText += " limit " + limit + " offset " + offset;
            log.Info(comm.CommandText);

            log.OutPrivate();
        }

        /// <summary>
        /// Create ParsedLog table column name
        /// </summary>
        /// <param name="colName">Column name</param>
        /// <returns>Column name with table name</returns>
        private string CreatePLColumnName(string colName)
        {
            return IntermediateLogConstants.TABLE_NAME_PARSED_LOGS + "." + colName;
        }

        /// <summary>
        /// Create Log files table column name
        /// </summary>
        /// <param name="colName">Column name</param>
        /// <returns>Column name with table name</returns>
        private string CreateLFColumnName(string colName)
        {
            return IntermediateLogConstants.TABLE_NAME_LOG_FILES + "." + colName;
        }

        /// <summary>
        /// Create Hashed values table name for join table
        /// </summary>
        /// <param name="colName">Column name</param>
        /// <returns>Table name</returns>
        private string CreateHVTableName(string colName)
        {
            return IntermediateLogConstants.TABLE_NAME_HASHED_VALUES + " as " + colName + HASHED_SUFFIX;
        }

        /// <summary>
        /// Create Hashed values table column name
        /// </summary>
        /// <param name="colName">Column name</param>
        /// <returns>Column name with table name</returns>
        private string CreateHVColumnName(string colName)
        {
            return colName + HASHED_SUFFIX + "." + IntermediateLogConstants.COL_NAME_HV_ID;
        }

        /// <summary>
        /// Create Log file table column name for join table
        /// </summary>
        /// <param name="colName">Column name</param>
        /// <returns>Column name with table name</returns>
        private string CreateHVColumnNameWithAlias(string colName)
        {
            return colName + HASHED_SUFFIX + "." + IntermediateLogConstants.COL_NAME_HV_VALUE + " as " + colName;
        }

        /// <summary>
        /// Add where clause to command object
        /// </summary>
        /// <param name="comm">Command</param>
        /// <param name="criteria">Search condition</param>
        /// <param name="appendWhere">Flag of append "where" clause</param>
        private void AddWhereClause(SQLiteCommand comm, SearchCriteria criteria, bool appendWhere)
        {
            log.InPrivate(comm, criteria);

            if (criteria != null)
            {
                comm.CommandText += criteria.CreateWhereClauseString(appendWhere);

                int index = 0;

                foreach (SearchCriterion criterion in criteria.CriterionList)
                {
                    if (criterion.OperatorType == SearchCriterion.OperatorTypeEnum.Between)
                    {
                        SQLiteParameter sqlParamFrom
                            = CreateParameter(criterion.Name + "From" + index.ToString(),
                                criterion.Values[0],
                                criterion.ColumnType,
                                criterion.Hashable);
                        comm.Parameters.Add(sqlParamFrom);

                        SQLiteParameter sqlParamTo
                            = CreateParameter(criterion.Name + "To" + index.ToString(),
                                criterion.Values[1],
                                criterion.ColumnType,
                                criterion.Hashable);
                        comm.Parameters.Add(sqlParamTo);
                    }
                    else
                    {
                        SQLiteParameter sqlParam
                            = CreateParameter(criterion.Name + index.ToString(),
                                criterion.Value,
                                criterion.ColumnType,
                                criterion.Hashable);
                        comm.Parameters.Add(sqlParam);
                    }

                    index++;
                }
            }

            log.OutPrivate();
        }

        /// <summary>
        /// Create where parameter
        /// </summary>
        /// <param name="name">Column name</param>
        /// <param name="value">Column value</param>
        /// <param name="colType">Column type</param>
        /// <param name="hashable">Flag of column value is hashed</param>
        /// <returns>Parameter object</returns>
        private SQLiteParameter CreateParameter(string name, string value, SearchCriterion.ColumnTypeEnum colType, bool hashable)
        {
            log.InPrivate(name, value, colType);

            SQLiteParameter sqlParam = new SQLiteParameter();

            if (hashable)
            {
                sqlParam.ParameterName = name;

                long valueID = GetHashedValueID(value);

                if (valueID == -1)
                {
                    throw new NotFoundHashedKeyException(name, value);
                }
                else
                {
                    sqlParam.Value = valueID;
                }
                sqlParam.DbType = DbType.UInt64;
            }
            else
            {
                sqlParam.ParameterName = name;
                sqlParam.Value = value;

                switch (colType)
                {
                    case SearchCriterion.ColumnTypeEnum.Number:
                        sqlParam.DbType = DbType.UInt64;
                        break;

                    default:
                        sqlParam.DbType = DbType.String;
                        break;
                }
            }
 
            log.OutPrivate();
            return sqlParam;
        }

        /// <summary>
        /// Get hashed value ID from database by specified value
        /// </summary>
        /// <param name="value">Hashed source value</param>
        /// <returns>Hashed ID</returns>
        private long GetHashedValueID(string value)
        {
            log.InPrivate(value);

            using (SQLiteCommand comm = connection.CreateCommand())
            {
                comm.CommandText
                    = "select * from " + IntermediateLogConstants.TABLE_NAME_HASHED_VALUES
                        + " where " + IntermediateLogConstants.COL_NAME_HV_VALUE + "= @Value";

                comm.Parameters.Add("Value", System.Data.DbType.String);
                comm.Parameters["Value"].Value = value;

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

        /// <summary>
        /// Set Highlight values to specified column value
        /// </summary>
        /// <param name="col">Target column value</param>
        /// <param name="defList">Highlight definition list</param>
        private void SetHighlights(ParsedLogColumn col, HighlightDefinitionList defList)
        {
            log.InPrivate(col, defList);

            if (col.ColumnDefinition.IsDateTimeField)
            {
                log.OutPrivate();
                return;
            }

            List<HighlightDefinition> targetDefList = defList.Find(col.ColumnDefinition);

            foreach (HighlightDefinition def in targetDefList)
            {
                string key = def.Keyword;
                string val = col.Value;

                if (!def.CaseSensitive)
                {
                    key = key.ToLower();
                    val = val.ToLower();
                }

                if (val.Contains(key))
                {
                    SetAllHightlightItems(key, val, col, def);
                }
            }

            log.OutPrivate();
        }

        /// <summary>
        /// Set hightlight item to specified value
        /// </summary>
        /// <param name="key">Highlight keyword</param>
        /// <param name="val">Target value</param>
        /// <param name="col">Log column</param>
        /// <param name="def">Highlight definition</param>
        private void SetAllHightlightItems(string key, string val, ParsedLogColumn col, HighlightDefinition def)
        {
            log.InPrivate(key, val, col);

            if (key == "")
            {
                return;
            }

            string tempVal = val;

            int removedCount = 0;

            while (true)
            {
                if (tempVal.Contains(key))
                {
                    int startIndex = tempVal.IndexOf(key);

                    Highlight highlight = new Highlight();
                    highlight.HighlightDefinition = def;

                    removedCount += startIndex;
                    highlight.StartIndex = removedCount;

                    removedCount += key.Length;
                    highlight.EndIndex = removedCount;
                    col.HighlightList.Add(highlight);

                    tempVal = tempVal.Substring(startIndex + key.Length);
                }
                else
                {
                    break;
                }
            }

            log.OutPrivate();
        }

        /// <summary>
        /// Get string value from database
        /// </summary>
        /// <param name="reader">Database data reader</param>
        /// <param name="colName">Column name</param>
        /// <returns>Column value</returns>
        private string GetStringValue(SQLiteDataReader reader, string colName)
        {
            log.InPrivate(reader, colName);

            object value = reader[colName];

            if(value == null)
            {
                log.OutPrivate(null);
                return null;
            }
            else
            {
                log.OutPrivate(value.ToString());
                return value.ToString();
            }
        }

        /// <summary>
        /// Get boolean value from database
        /// </summary>
        /// <param name="reader">Database data reader</param>
        /// <param name="colName">Column name</param>
        /// <returns>Column value</returns>
        private bool GetBooleanValue(SQLiteDataReader reader, string colName)
        {
            log.InPrivate(reader, colName);

            object value = reader[colName];

            if (value == null)
            {
                log.OutPrivate(false);
                return false;
            }
            else if(value.ToString() == "1")
            {
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
        /// Get integer value from database
        /// </summary>
        /// <param name="reader">Database data reader</param>
        /// <param name="colName">Column name</param>
        /// <returns>Column value</returns>
        private int GetIntValue(SQLiteDataReader reader, string colName)
        {
            log.InPrivate(reader, colName);

            object value = reader[colName];
            
            if(value == null)
            {
                log.OutPrivate(0);
                return 0;
            }
            else
            {
                int val = int.Parse(value.ToString());

                log.OutPrivate(val);
                return val;
            }
        }
    }
}
