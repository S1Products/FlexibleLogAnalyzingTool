using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlatEngine.IntermediateLog;

namespace FlatEngine
{
    [Serializable]
    public class FlatProject
    {
        /// <summary>
        /// Project name
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Flag of show file name to DataGrid
        /// </summary>
        public bool ShowFileName { get; set; }

        /// <summary>
        /// Analyzed pattern definition
        /// </summary>
        public PatternDefinition PatternDefinition { get; set; }

        /// <summary>
        /// Displayed log's range criteria
        /// </summary>
        public SearchCriteria RangeCriteria { get; set; }

        /// <summary>
        /// Extracted log's search criteria
        /// </summary>
        public SearchCriteria ColumnsSearchCriteria { get; set; }

        /// <summary>
        /// Get SearchCriteria includes Range and Columns criterions
        /// </summary>
        public SearchCriteria SearchCriteria 
        { 
            get 
            {
                SearchCriteria criteria = new SearchCriteria();

                if (RangeCriteria != null)
                {
                    criteria.CriterionList.AddRange(RangeCriteria.CriterionList);
                }

                if (ColumnsSearchCriteria != null)
                {
                    criteria.CriterionList.AddRange(ColumnsSearchCriteria.CriterionList);
                }

                return criteria;
            }
        }

        /// <summary>
        /// Highlighted definition list
        /// </summary>
        public HighlightDefinitionList HighlightDefinitionList { get; set; }

        /// <summary>
        /// Current working directory.
        /// </summary>
        public string WorkingDirectory { get; set; }

        public FlatProject()
        {
            PatternDefinition = new PatternDefinition();
            RangeCriteria = new SearchCriteria();
            ColumnsSearchCriteria = new SearchCriteria();
            HighlightDefinitionList = new HighlightDefinitionList();
        }

        public override string ToString()
        {
            return "ProjectName=" + ProjectName + ", WorkingDirectory=" + WorkingDirectory;
        }
    }
}
