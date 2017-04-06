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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FlatEngine;
using FlatEngine.IntermediateLog;

namespace FlexibleLogAnalyzerTool
{
    public partial class FilteringColumnSettingDialog : Form
    {
        private const int TERM_INDEX = 0;
        private const int OPERATOR_INDEX = 1;
        private const int VALUE_INDEX = 2;

        private const string TERM_AND = "And";
        private const string TERM_OR = "Or";

        private const string OPERATOR_IS_EQUAL = "=";
        private const string OPERATOR_IS_NOT_EQUAL = "!=";
        private const string OPERATOR_LESS_THAN = "<";
        private const string OPERATOR_LESS_THAN_EQUAL = "<=";
        private const string OPERATOR_GREATER_THAN = ">";
        private const string OPERATOR_GREATER_THAN_EQUAL = ">=";
        private const string OPERATOR_LIKE = "Like";
        private const string OPERATOR_NOT_LIKE = "NotLike";

        private ColumnDefinitionList colDefList;
        private SearchCriteria searchCriteria;

        public FilteringColumnSettingDialog(FlatProject project)
        {
            InitializeComponent();
            this.colDefList = project.PatternDefinition.ColumnDefinitionList;
            this.searchCriteria = SearchCriteria.Copy(project.ColumnsSearchCriteria);

            if (this.searchCriteria == null)
            {
                this.searchCriteria = new SearchCriteria();
            }

            ShowColumnList();

            if (ColumnListBox.Items.Count > 0)
            {
                ColumnListBox.SelectedIndex = 0;
            }
        }

        public SearchCriteria SearchCriteria
        {
            get
            {
                return searchCriteria;
            }
        }

        private void ShowColumnList()
        {
            ColumnListBox.Items.Clear();
            ColumnListBox.Items.AddRange(colDefList.ToArray());

            if (ColumnListBox.Items.Count > 0)
            {
                ColumnListBox.SelectedIndex = 0;
            }
        }

        private void ShowSearchCriteria(ColumnDefinition colDef)
        {
            SearchCriteriaDataGridView.Rows.Clear();

            SearchCriterion[] criterions = searchCriteria.CriterionList.Find(colDef.ColumnName);

            foreach (SearchCriterion criterion in criterions)
            {
                SearchCriteriaDataGridView.Rows.Add();
                DataGridViewRow row = SearchCriteriaDataGridView.Rows[SearchCriteriaDataGridView.Rows.Count - 2];

                SetTermColumn(criterion, row);

                SetOperatorColumn(criterion, row);

                SetValueColumn(colDef, criterion, row);
            }
        }

        private void SetTermColumn(SearchCriterion criterion, DataGridViewRow row)
        {
            switch(criterion.TerminalType)
            {
                case SearchCriterion.TerminalTypeEnum.Or:
                    row.Cells[TERM_INDEX].Value = TERM_OR;
                    break;

                default:
                    row.Cells[TERM_INDEX].Value = TERM_AND;
                    break;
            }
        }

        private void SetOperatorColumn(SearchCriterion criterion, DataGridViewRow row)
        {
            switch (criterion.OperatorType)
            {
                case SearchCriterion.OperatorTypeEnum.IsEqual:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_IS_EQUAL;
                    break;

                case SearchCriterion.OperatorTypeEnum.IsNotEqual:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_IS_NOT_EQUAL;
                    break;

                case SearchCriterion.OperatorTypeEnum.LessThan:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_LESS_THAN;
                    break;

                case SearchCriterion.OperatorTypeEnum.LessThanEqual:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_LESS_THAN_EQUAL;
                    break;

                case SearchCriterion.OperatorTypeEnum.GreaterThan:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_GREATER_THAN;
                    break;

                case SearchCriterion.OperatorTypeEnum.GreaterThanEqual:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_GREATER_THAN_EQUAL;
                    break;

                case SearchCriterion.OperatorTypeEnum.Like:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_LIKE;
                    break;

                case SearchCriterion.OperatorTypeEnum.NotLike:
                    row.Cells[OPERATOR_INDEX].Value = OPERATOR_NOT_LIKE;
                    break;

            }
        }

        private void SetValueColumn(ColumnDefinition colDef, SearchCriterion criterion, DataGridViewRow row)
        {
            if (colDef.IsDateTimeField)
            {
                long value = 0;
                long.TryParse(criterion.Value, out value);

                DateTime dateTime = new DateTime(value);
                row.Cells[VALUE_INDEX].Value = dateTime.ToString(Properties.Settings.Default.DateTimeFormat);
            }
            else
            {
                row.Cells[VALUE_INDEX].Value = criterion.Value;
            }
        }

        private void SetTermValue(SearchCriterion criterion, string cellValue)
        {
            if (cellValue == TERM_OR)
            {
                criterion.TerminalType = SearchCriterion.TerminalTypeEnum.Or;
            }
            else
            {
                criterion.TerminalType = SearchCriterion.TerminalTypeEnum.And;
            }
        }

        private void SetOperatorValue(SearchCriterion criterion, string cellValue)
        {
            if (cellValue == OPERATOR_IS_EQUAL)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.IsEqual;
            }
            else if (cellValue == OPERATOR_IS_NOT_EQUAL)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.IsNotEqual;
            }
            else if (cellValue == OPERATOR_LESS_THAN)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.LessThan;
            }
            else if (cellValue == OPERATOR_LESS_THAN_EQUAL)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.LessThanEqual;
            }
            else if (cellValue == OPERATOR_GREATER_THAN)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.GreaterThan;
            }
            else if (cellValue == OPERATOR_GREATER_THAN_EQUAL)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.GreaterThanEqual;
            }
            else if (cellValue == OPERATOR_LIKE)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.Like;
            }
            else if (cellValue == OPERATOR_NOT_LIKE)
            {
                criterion.OperatorType = SearchCriterion.OperatorTypeEnum.NotLike;
            }
        }

        private void SetValue(ColumnDefinition colDef, SearchCriterion criterion, string cellValue)
        {
            if (colDef.IsDateTimeField)
            {
                DateTime dateTime;

                if (DateTime.TryParse(cellValue, out dateTime))
                {
                    criterion.Value = dateTime.Ticks.ToString();
                }
            }
            else
            {
                criterion.Value = cellValue;
            }
        }

        private void DialogOKButton_Click(object sender, EventArgs e)
        {

        }

        #region "Events"

        #region "Select column list"

        private void ColumnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColumnListBox.SelectedIndex == -1)
            {
                return;
            }

            ShowSearchCriteria((ColumnDefinition)ColumnListBox.SelectedItem);
        }

        #endregion

        #region "Search conditions data grid"

        #region "Add"

        private void SearchCriteriaDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.SelectedItem;

            SearchCriterion criterion = new SearchCriterion();
            criterion.Name = colDef.ColumnName;
            criterion.Hashable = colDef.Hashable;

            if (colDef.IsDateTimeField || colDef.Hashable)
            {
                criterion.ColumnType = SearchCriterion.ColumnTypeEnum.Number;
            }
            else
            {
                criterion.ColumnType = SearchCriterion.ColumnTypeEnum.String;
            }

            searchCriteria.CriterionList.Add(criterion);
        }

        #endregion

        #region "Update"

        private void SearchCriteriaDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.SelectedItem;

            SearchCriterion[] criterions = searchCriteria.CriterionList.Find(colDef.ColumnName);
            SearchCriterion criterion = criterions[e.RowIndex];

            DataGridViewCell cell = SearchCriteriaDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex == TERM_INDEX)
            {
                SetTermValue(criterion, cell.Value.ToString());
            }
            else if (e.ColumnIndex == OPERATOR_INDEX)
            {
                SetOperatorValue(criterion, cell.Value.ToString());
            }
            else
            {
                if (cell.Value == null)
                {
                    SetValue(colDef, criterion, "");
                }
                else
                {
                    SetValue(colDef, criterion, cell.Value.ToString());
                }
            }
        }

        #endregion

        #region "Delete"

        private void SearchCriteriaDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.SelectedItem;

            SearchCriterion[] criterions = searchCriteria.CriterionList.Find(colDef.ColumnName);
            searchCriteria.CriterionList.Remove(criterions[e.Row.Index]);
        }

        #endregion

        #endregion

        #endregion
    }
}
