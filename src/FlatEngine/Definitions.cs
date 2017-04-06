using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlatEngine
{
    [Serializable]
    public class PatternDefinition
    {
        /// <summary>
        /// Pattern ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Pattern Name
        /// </summary>
        public string PatternName { get; set; }

        /// <summary>
        /// Regular expression for log analyze
        /// </summary>
        public string RegularExpression { get; set; }

        /// <summary>
        /// Analyzed column definitions
        /// </summary>
        public ColumnDefinitionList ColumnDefinitionList { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public PatternDefinition()
        {
            ColumnDefinitionList = new ColumnDefinitionList();
        }

        /// <summary>
        /// Create new pattern definition and generate UUID to Pattern ID field.
        /// </summary>
        /// <returns>New pattern definition</returns>
        public static PatternDefinition CreateNew()
        {
            PatternDefinition pattern = CreateDefault();
            pattern.ID = Guid.NewGuid().ToString();

            return pattern;
        }

        /// <summary>
        /// Create default pattern deinition.
        /// </summary>
        /// <returns>New default pattern definition</returns>
        public static PatternDefinition CreateDefault()
        {
            PatternDefinition patternDef = new PatternDefinition();
            patternDef.ID = "default";
            patternDef.PatternName = "New";
            patternDef.RegularExpression = "(.*)";

            ColumnDefinition colDef = new ColumnDefinition();
            colDef.Order = 0;
            colDef.Hashable = false;
            colDef.IsDateTimeField = false;
            colDef.ColumnName = "Message";

            patternDef.ColumnDefinitionList.Add(colDef);

            return patternDef;
        }

        /// <summary>
        /// Deep copy source pattern definition
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static PatternDefinition Copy(PatternDefinition source)
        {
            PatternDefinition dest = new PatternDefinition();
            dest.ID = Guid.NewGuid().ToString();
            dest.PatternName = source.PatternName + " copy";
            dest.RegularExpression = source.RegularExpression;

            foreach (ColumnDefinition col in source.ColumnDefinitionList)
            {
                dest.ColumnDefinitionList.Add(ColumnDefinition.Copy(col));
            }

            return dest;
        }
    }

    [Serializable]
    public class ColumnDefinitionList : List<ColumnDefinition>
    {
        /// <summary>
        /// Sort column order with ColumnDefinition.Order property
        /// </summary>
        public new void Sort()
        {
            this.Sort(new ColumnOrderComparer());
        }

        /// <summary>
        /// Find specified column name definition
        /// </summary>
        /// <param name="colName">Target column name</param>
        /// <returns>Found definition. If not find definition then null will be returned.</returns>
        public ColumnDefinition Find(string colName)
        {
            foreach (ColumnDefinition def in this)
            {
                if (def.ColumnName == colName)
                {
                    return def;
                }
            }

            return null;
        }

        /// <summary>
        /// Column order comparer for Sort function
        /// </summary>
        class ColumnOrderComparer : IComparer<ColumnDefinition>
        {
            public int Compare(ColumnDefinition x, ColumnDefinition y)
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        return x.Order.CompareTo(y.Order);
                    }
                }
            }
        }
    }

    [Serializable]
    public class ColumnDefinition
    {
        /// <summary>
        /// Column name
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// Column order
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Column visibility
        /// </summary>
        public bool Visble { get; set; }

        /// <summary>
        /// Use hashed value
        /// </summary>
        public bool Hashable { get; set; }

        /// <summary>
        /// Flag of DateTime field
        /// </summary>
        public bool IsDateTimeField { get; set; }

        /// <summary>
        /// DateTime format for parse log
        /// </summary>
        public string DateTimeFormat { get; set; }

        /// <summary>
        /// Resizable column width
        /// </summary>
        public bool Resizable { get; set; }

        public ColumnDefinition()
        {
            this.Visble = true;
        }

        /// <summary>
        /// Deep copy source column definition
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static ColumnDefinition Copy(ColumnDefinition source)
        {
            ColumnDefinition col = new ColumnDefinition();
            col.ColumnName = source.ColumnName;
            col.DateTimeFormat = source.DateTimeFormat;
            col.Hashable = source.Hashable;
            col.IsDateTimeField = source.IsDateTimeField;
            col.Order = source.Order;
            col.Visble = source.Visble;
            col.Resizable = source.Resizable;

            return col;
        }

        public override string ToString()
        {
            return ColumnName;
        }
    }

    [Serializable]
    public class HighlightDefinitionList : List<HighlightDefinition>
    {

        /// <summary>
        /// Find highlight definition by specified column definition
        /// </summary>
        /// <param name="colDef">Target column definition</param>
        /// <returns>Highligh definition list fo specified column definition</returns>
        public List<HighlightDefinition> Find(ColumnDefinition colDef)
        {
            List<HighlightDefinition> defList = new List<HighlightDefinition>();

            foreach (HighlightDefinition def in this)
            {
                if (def.TargetColumn.ColumnName == colDef.ColumnName)
                {
                    defList.Add(def);
                }
            }

            return defList;
        }

        /// <summary>
        /// Deep copy source highlight definition list
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static HighlightDefinitionList Copy(HighlightDefinitionList source)
        {
            HighlightDefinitionList dest = new HighlightDefinitionList();

            foreach (HighlightDefinition def in source)
            {
                dest.Add(HighlightDefinition.Copy(def));
            }

            return dest;
        }
    }

    [Serializable]
    public class HighlightDefinition
    {
        /// <summary>
        /// Highlight target column
        /// </summary>
        public ColumnDefinition TargetColumn { get; set; }

        /// <summary>
        /// Highlight keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// Highlight color
        /// </summary>
        public Color HighlightColor { get; set; }

        /// <summary>
        /// Is jumpable highlight
        /// </summary>
        public bool Jumpable { get; set; }

        /// <summary>
        /// Find highlight with case sensitive
        /// </summary>
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Deep copy highlight definition
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static HighlightDefinition Copy(HighlightDefinition source)
        {
            HighlightDefinition dest = new HighlightDefinition();
            dest.Keyword = source.Keyword;
            dest.TargetColumn = source.TargetColumn;
            dest.HighlightColor = source.HighlightColor;
            dest.Jumpable = source.Jumpable;
            dest.CaseSensitive = source.CaseSensitive;

            return dest;
        }
    }
}
