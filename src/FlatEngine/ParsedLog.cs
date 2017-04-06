using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatEngine
{
    /// <summary>
    /// Parsed log data
    /// </summary>
    public class ParsedLog
    {
        /// <summary>
        /// Total line count
        /// </summary>
        public int TotalLineCount { get; set; }

        /// <summary>
        /// Total found line count
        /// </summary>
        public int TargetLineCount { get; set; }

        /// <summary>
        /// Fetched parsed log line list
        /// </summary>
        public List<ParsedLogLine> LogLineList { get; set; }

        public ParsedLog()
        {
            LogLineList = new List<ParsedLogLine>();
        }
    }

    /// <summary>
    /// Parsed log line data
    /// </summary>
    public class ParsedLogLine
    {
        /// <summary>
        /// Line number of the log file
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Log file name and ID
        /// </summary>
        public FileValue File { get; set; }

        /// <summary>
        /// Parsed columns
        /// </summary>
        public List<ParsedLogColumn> ColumnList { get; set; }

        /// <summary>
        /// Flag of has error
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        /// Not parsed log line for has error row
        /// </summary>
        public string NotParsedLog { get; set; }

        public ParsedLogLine()
        {
            NotParsedLog = "";
            ColumnList = new List<ParsedLogColumn>();
        }
    }

    /// <summary>
    ///  Parsed log column data
    /// </summary>
    public class ParsedLogColumn
    {
        /// <summary>
        /// Founded highlight list
        /// </summary>
        private HighlightList highlightList = new HighlightList();

        /// <summary>
        /// Column definition
        /// </summary>
        public ColumnDefinition ColumnDefinition { get; set; }

        /// <summary>
        /// Column value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Hashed value
        /// </summary>
        public HashedValue HashedValue { get; set; }

        /// <summary>
        /// Highlight list property
        /// </summary>
        public HighlightList HighlightList
        {
            get
            {
                return highlightList;
            }
            set
            {
                highlightList = value;
            }
        }
    }

    public class HighlightList : List<Highlight>
    {
    }

    public class Highlight
    {
        /// <summary>
        /// Highlight definition
        /// </summary>
        public HighlightDefinition HighlightDefinition { get; set; }

        /// <summary>
        /// Highlight start position
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// Highlight end position
        /// </summary>
        public int EndIndex { get; set; }
    }

    public class FileValue
    {
        /// <summary>
        /// Log file ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Log file name
        /// </summary>
        public string Name { get; set; }
    }

    public class HashedValue
    {
        /// <summary>
        /// Hashed value ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Hashed value
        /// </summary>
        public string Value { get; set; }
    }
}
