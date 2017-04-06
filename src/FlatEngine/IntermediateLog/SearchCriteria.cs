using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace FlatEngine.IntermediateLog
{
    [Serializable]
    public class SearchCriteria
    {
        /// <summary>
        /// Search conditions
        /// </summary>
        public SearchCriterionList CriterionList { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SearchCriteria()
        {
            CriterionList = new SearchCriterionList();
        }

        /// <summary>
        /// Deep copy source SearchCriteria
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static SearchCriteria Copy(SearchCriteria source)
        {
            if (source == null)
            {
                return null;
            }

            SearchCriteria target = new SearchCriteria();

            foreach (SearchCriterion criterion in source.CriterionList)
            {
                SearchCriterion targetCriterion = SearchCriterion.Copy(criterion);
                target.CriterionList.Add(targetCriterion);
            }

            return target;
        }

        /// <summary>
        /// Create WHERE clause from seach criteria
        /// </summary>
        /// <param name="appendWhere">Flag of add WHERE clause</param>
        /// <returns>WHERE caluse</returns>
        public string CreateWhereClauseString(bool appendWhere)
        {
            if(CriterionList.Count == 0)
            {
                return "";
            }

            StringBuilder builder = new StringBuilder();
            if (appendWhere)
            {
                builder.Append(" where (");
            }
            else
            {
                builder.Append(" and (");
            }

            for(int i = 0; i < CriterionList.Count; i++)
            {
                SearchCriterion criterion = CriterionList[i];

                if(i != 0)
                {
                    if(criterion.TerminalType == SearchCriterion.TerminalTypeEnum.And)
                    {
                        builder.Append(" and ");
                    }
                    else
                    {
                        builder.Append(" or ");
                    }
                }

                builder.Append(criterion.GetWhereStatementWithParam(i.ToString()));
            }

            builder.Append(")");

            return builder.ToString();
        }
    }

    [Serializable]
    public class SearchCriterionList : List<SearchCriterion>
    {
        /// <summary>
        /// Find search criterions with specified name
        /// </summary>
        /// <param name="name">Target name</param>
        /// <returns>Found search criterions</returns>
        public SearchCriterion[] Find(string name)
        {
            List<SearchCriterion> foundList = new List<SearchCriterion>();

            foreach (SearchCriterion criterion in this)
            {
                if (criterion.Name == name)
                {
                    foundList.Add(criterion);
                }
            }

            return foundList.ToArray();
        }
    }

    [Serializable]
    public class SearchCriterion
    {
        /// <summary>
        /// Search criterion terminal type
        /// </summary>
        public enum TerminalTypeEnum : int
        {
            /// <summary>
            /// AND
            /// </summary>
            And = 0,
            
            /// <summary>
            /// OR
            /// </summary>
            Or = 1
        }

        /// <summary>
        /// Search criterion column type
        /// </summary>
        public enum ColumnTypeEnum : int
        {
            /// <summary>
            /// Number column
            /// </summary>
            Number = 0,

            /// <summary>
            /// String column
            /// </summary>
            String = 1,
        }

        /// <summary>
        /// Search criterion operator type
        /// </summary>
        public enum OperatorTypeEnum : int
        {
            /// <summary>
            /// =
            /// </summary>
            IsEqual = 0,

            /// <summary>
            /// !=
            /// </summary>
            IsNotEqual = 1,

            /// <summary>
            /// <
            /// </summary>
            LessThan = 2,

            /// <summary>
            /// <=
            /// </summary>
            LessThanEqual = 3,

            /// <summary>
            /// >
            /// </summary>
            GreaterThan = 4,

            /// <summary>
            /// >=
            /// </summary>
            GreaterThanEqual = 5,

            /// <summary>
            /// Like
            /// </summary>
            Like = 6,

            /// <summary>
            /// Not like
            /// </summary>
            NotLike = 7,

            /// <summary>
            /// Between
            /// </summary>
            Between = 8,

            /// <summary>
            /// In (Not used.)
            /// </summary>
            In = 9
        }

        /// <summary>
        /// Terminal type property
        /// </summary>
        public TerminalTypeEnum TerminalType { get; set; }

        /// <summary>
        /// Operator type property
        /// </summary>
        public OperatorTypeEnum OperatorType { get; set; }

        /// <summary>
        /// Column name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Column value property
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Flag of Is hashable filed
        /// </summary>
        public bool Hashable { get; set; }

        /// <summary>
        /// Column value for multiple values operator (Between or In)
        /// </summary>
        public List<string> Values { get; set; }

        /// <summary>
        /// Column type property
        /// </summary>
        public ColumnTypeEnum ColumnType { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SearchCriterion()
        {
            Values = new List<string>();
        }

        /// <summary>
        /// Deep copy source SearchCriterion
        /// </summary>
        /// <param name="source">Copy source</param>
        /// <returns>Deep copied instance</returns>
        public static SearchCriterion Copy(SearchCriterion source)
        {
            SearchCriterion target = new SearchCriterion();
            target.ColumnType = source.ColumnType;
            target.Name = source.Name;
            target.OperatorType = source.OperatorType;
            target.TerminalType = source.TerminalType;
            target.Value = source.Value;
            target.Hashable = source.Hashable;
            target.Values.AddRange(source.Values);

            return target;
        }

        /// <summary>
        /// Get WHERE clause string with parameter keywords
        /// </summary>
        /// <param name="paramIndex">Parameter index</param>
        /// <returns>WHERE caluse</returns>
        public string GetWhereStatementWithParam(string paramIndex)
        {
            switch (OperatorType)
            {
                case OperatorTypeEnum.IsNotEqual:
                    return AppendNameAndParam("<>", paramIndex);

                case OperatorTypeEnum.GreaterThan:
                    return AppendNameAndParam(">", paramIndex);

                case OperatorTypeEnum.GreaterThanEqual:
                    return AppendNameAndParam(">=", paramIndex);

                case OperatorTypeEnum.LessThan:
                    return AppendNameAndParam("<", paramIndex);

                case OperatorTypeEnum.LessThanEqual:
                    return AppendNameAndParam("<=", paramIndex);

                case OperatorTypeEnum.Like:
                    return AppendNameAndParam(" like ", paramIndex);

                case OperatorTypeEnum.NotLike:
                    return AppendNameAndParam(" not like ", paramIndex);

                case OperatorTypeEnum.Between:
                    return Name + " between @" + Name + "From" + paramIndex + " and @" + Name + "To" + paramIndex;

                case OperatorTypeEnum.In:
                    return AppendNameAndParam(" in(", paramIndex) + ")";

                case OperatorTypeEnum.IsEqual:
                default:
                    return AppendNameAndParam("=", paramIndex);
            }
        }

        public override string ToString()
        {
            return GetWhereStatementWithParam("");
        }

        private string AppendNameAndParam(string opr, string paramIndex)
        {
            return Name + opr + "@" + Name + paramIndex;
        }
    }
}
