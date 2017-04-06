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
