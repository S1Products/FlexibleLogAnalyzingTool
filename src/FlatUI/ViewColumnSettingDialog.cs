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

namespace FlexibleLogAnalyzerTool
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Miura Acoustic</author>
    public partial class ViewColumnSettingDialog : Form
    {
        private ColumnDefinitionList columnDefList;

        public ViewColumnSettingDialog(FlatProject project)
        {
            InitializeComponent();
            columnDefList = project.PatternDefinition.ColumnDefinitionList;

            ShowFileNameCheckBox.Checked = project.ShowFileName;
            ShowColumnList();
        }

        public bool ShowFileName
        {
            get
            {
                return ShowFileNameCheckBox.Checked;
            }
        }

        public ColumnDefinitionList ColumnDefinitionList
        {
            get
            {
                return columnDefList;
            }
        }

        private void ShowColumnList()
        {
            ColumnListBox.Items.Clear();

            columnDefList.Sort();

            foreach (ColumnDefinition colDef in columnDefList)
            {
                ColumnListBox.Items.Add(colDef);

                int index = ColumnListBox.Items.IndexOf(colDef);
                ColumnListBox.SetItemChecked(index, colDef.Visble);
            }
        }

        private void DialogOKButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ColumnListBox.Items.Count; i++)
            {
                ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.Items[i];
                colDef.Visble = ColumnListBox.GetItemChecked(i);
                colDef.Order = i;
            }

            columnDefList.Sort();
        }

        private void OrderUpButton_Click(object sender, EventArgs e)
        {
            int selIndex = ColumnListBox.SelectedIndex;
            if (selIndex <= 0)
            {
                return;
            }

            ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.SelectedItem;
            ColumnListBox.Items.Remove(colDef);
            ColumnListBox.Items.Insert(selIndex - 1, colDef);

            ColumnListBox.SelectedItem = colDef;
        }

        private void OrderDownButton_Click(object sender, EventArgs e)
        {
            int selIndex = ColumnListBox.SelectedIndex;
            if (selIndex == -1 || selIndex == ColumnListBox.Items.Count - 1)
            {
                return;
            }

            ColumnDefinition colDef = (ColumnDefinition)ColumnListBox.SelectedItem;
            ColumnListBox.Items.Remove(colDef);
            ColumnListBox.Items.Insert(selIndex + 1, colDef);

            ColumnListBox.SelectedItem = colDef;
        }
    }
}
