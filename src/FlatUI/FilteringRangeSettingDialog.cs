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
    public partial class FilteringRangeSettingDialog : Form
    {
        private PatternDefinition patternDef;
        private SearchCriteria rangeCriteria;

        private List<FileValue> fileValueList;

        public SearchCriteria RangeCriteria
        {
            get
            {
                return rangeCriteria;
            }
        }

        public FilteringRangeSettingDialog(FlatProject project, List<FileValue> fileValueList)
        {
            InitializeComponent();

            this.patternDef = project.PatternDefinition;
            this.rangeCriteria = SearchCriteria.Copy(project.RangeCriteria);

            this.fileValueList = fileValueList;

            foreach (FileValue value in fileValueList)
            {
                LogFileNameComboBox.Items.Add(value.Name);
            }

            if (LogFileNameComboBox.Items.Count > 0)
            {
                LogFileNameComboBox.SelectedIndex = 0;
            }

            ShowRangeFilterValues();
        }

        private void ShowRangeFilterValues()
        {
            foreach (SearchCriterion criterion in rangeCriteria.CriterionList)
            {
                if (criterion.Name == IntermediateLogConstants.COL_NAME_PL_LINE_NUM)
                {
                    LineCountCheckBox.Checked = true;
                    StartNumericUpDown.Value = int.Parse(criterion.Values[0]);
                    EndNumericUpDown.Value = int.Parse(criterion.Values[1]);
                }
                else if (criterion.Name == IntermediateLogConstants.COL_NAME_PL_FILE_ID)
                {
                    LineCountCheckBox.Checked = true;

                    int index = FindFileIDIndex(int.Parse(criterion.Value));
                    if (index > -1)
                    {
                        LogFileNameComboBox.SelectedIndex = index;
                    }
                }
                else
                {
                    DateCheckBox.Checked = true;
                    StartDateTimePicker.Value = new DateTime(long.Parse(criterion.Values[0]));
                    EndDateTimePicker.Value = new DateTime(long.Parse(criterion.Values[1]));
                }
            }
        }

        private int FindFileIDIndex(int fileID)
        {
            for (int i = 0; i < fileValueList.Count; i++) 
            {
                if (fileValueList[i].ID == fileID)
                {
                    return i;
                }
            }

            return -1;
        }

        private void DialogOKButton_Click(object sender, EventArgs e)
        {
            rangeCriteria.CriterionList.Clear();

            if (DateCheckBox.Checked)
            {
                ColumnDefinition dateTimeCol = GetDateTimeColumn();

                if (dateTimeCol != null)
                {
                    DateTime start = StartDateTimePicker.Value;
                    DateTime end = EndDateTimePicker.Value;

                    SearchCriterion criterion = new SearchCriterion();
                    criterion.ColumnType = SearchCriterion.ColumnTypeEnum.Number;
                    criterion.Name = dateTimeCol.ColumnName;
                    criterion.OperatorType = SearchCriterion.OperatorTypeEnum.Between;
                    criterion.Values.Add(start.Ticks.ToString());
                    criterion.Values.Add(end.Ticks.ToString());

                    rangeCriteria.CriterionList.Add(criterion);
                }
            }

            if (LineCountCheckBox.Checked)
            {
                SearchCriterion countCriterion = new SearchCriterion();
                countCriterion.ColumnType = SearchCriterion.ColumnTypeEnum.Number;
                countCriterion.Name = IntermediateLogConstants.COL_NAME_PL_LINE_NUM;
                countCriterion.OperatorType = SearchCriterion.OperatorTypeEnum.Between;
                countCriterion.Values.Add(StartNumericUpDown.Value.ToString());
                countCriterion.Values.Add(EndNumericUpDown.Value.ToString());
                rangeCriteria.CriterionList.Add(countCriterion);

                SearchCriterion fileNameCriterion = new SearchCriterion();
                fileNameCriterion.ColumnType = SearchCriterion.ColumnTypeEnum.Number;
                fileNameCriterion.Name = IntermediateLogConstants.COL_NAME_PL_FILE_ID;
                fileNameCriterion.OperatorType = SearchCriterion.OperatorTypeEnum.IsEqual;
                fileNameCriterion.Value = fileValueList[LogFileNameComboBox.SelectedIndex].ID.ToString();
                rangeCriteria.CriterionList.Add(fileNameCriterion);
            }
        }

        private ColumnDefinition GetDateTimeColumn()
        {
            foreach (ColumnDefinition colDef in patternDef.ColumnDefinitionList)
            {
                if (colDef.IsDateTimeField)
                {
                    return colDef;
                }
            }

            return null;
        }
    }
}
