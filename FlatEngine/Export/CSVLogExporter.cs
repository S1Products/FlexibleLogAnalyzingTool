using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlatEngine.Export
{
    public class CSVLogExporter : LogExporter
    {
        public const string DEFAULT_DELIMITER = ",";
        public const string DATE_TIME_FORMAT = "MM/dd HH:mm:ss.fff";

        private StreamWriter writer = null;

        public string Delimiter { get; set; }

        public CSVLogExporter(string fileName)
        {
            this.Delimiter = DEFAULT_DELIMITER;

            writer = new StreamWriter(fileName);
        }

        public CSVLogExporter(string fileName, string delimiter)
        {
            this.Delimiter = delimiter;

            writer = new StreamWriter(fileName);
        }

        public CSVLogExporter(string fileName, string delimiter, bool append, Encoding enc)
        {
            this.Delimiter = delimiter;

            writer = new StreamWriter(fileName, append, enc);
        }

        public override void OnRenderDocumentHeader(FlatProject project, ParsedLog log)
        {
            writer.WriteLine("*****************************************");
            writer.WriteLine(" Project name: " + project.ProjectName);
            writer.WriteLine(" Created date: " + DateTime.Now.ToString());
            writer.WriteLine("*****************************************");

            StringBuilder sb = new StringBuilder();

            if (project.ShowFileName)
            {
                sb.Append("FileName" + Delimiter);
            }

            sb.Append("Line" + Delimiter);

            foreach (ColumnDefinition colDef in project.PatternDefinition.ColumnDefinitionList)
            {
                sb.Append(colDef.ColumnName + Delimiter);
            }

            RemoveLastDelimiter(sb);

            writer.WriteLine(sb.ToString());
        }

        public override void OnRenderMain(FlatProject project, ParsedLog log)
        {
            foreach (ParsedLogLine line in log.LogLineList)
            {
                StringBuilder sb = new StringBuilder();

                if (project.ShowFileName)
                {
                    sb.Append(line.File.Name);
                    sb.Append(this.Delimiter);
                }

                sb.Append(line.LineNumber);
                sb.Append(this.Delimiter);

                if (line.HasError)
                {
                    sb.Append(line.NotParsedLog);
                }
                else
                {
                    foreach (ParsedLogColumn col in line.ColumnList)
                    {
                        if (col.ColumnDefinition.IsDateTimeField)
                        {
                            DateTime time = new DateTime(long.Parse(col.Value));
                            sb.Append(time.ToString(DATE_TIME_FORMAT));
                        }
                        else
                        {
                            sb.Append(col.Value);
                        }

                        sb.Append(this.Delimiter);
                    }

                    RemoveLastDelimiter(sb);
                }

                writer.WriteLine(sb.ToString());
            }
        }

        public override void OnRenderDocumentFooter(FlatProject project, ParsedLog log)
        {
            // Nothing to do
        }

        public override void OnClose()
        {
            writer.Close();
        }

        private void RemoveLastDelimiter(StringBuilder sb)
        {
            sb.Remove(sb.Length - Delimiter.Length, Delimiter.Length);
        }
    }
}
