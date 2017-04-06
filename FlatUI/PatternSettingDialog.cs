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
    public partial class PatternSettingDialog : Form
    {
        public const int COL_INDEX_COLUMN_NAME = 0;
        public const int COL_INDEX_IS_DATETIME = COL_INDEX_COLUMN_NAME + 1;
        public const int COL_INDEX_DATETIME_FORMAT = COL_INDEX_IS_DATETIME + 1;
        public const int COL_INDEX_VISIBLE = COL_INDEX_DATETIME_FORMAT + 1;
        public const int COL_INDEX_HASHABLE = COL_INDEX_VISIBLE + 1;
        public const int COL_INDEX_RESIABLE = COL_INDEX_HASHABLE + 1;

        private List<PatternDefinition> patternList;

        public PatternSettingDialog()
        {
            InitializeComponent();
        }

        #region "Event"

        private void AnalyzePatternSettingDialog_Load(object sender, EventArgs e)
        {
            patternList = SettingFileAccessor.LoadPatternDefinitionList(Application.StartupPath);
            ShowPatternList();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (PatternListBox.SelectedIndex == -1)
            {
                MessageBox.Show(Properties.Resources.MessageChoosePattern);
                return;
            }

            PatternDefinition target = patternList[PatternListBox.SelectedIndex];

            RegexTestForm form = new RegexTestForm(target.RegularExpression);
            if (form.ShowDialog() == DialogResult.OK)
            {
                target.RegularExpression = form.RegularExpression;
                ShowPatternDetail(target);
            }
        }

        #region "Pattern accessor"

        private void AddButton_Click(object sender, EventArgs e)
        {
            PatternDefinition pattern 
                = SettingFileAccessor.AddNewPatternDefinition(Application.StartupPath);

            patternList.Add(pattern);

            ShowPatternList();
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            if (PatternListBox.SelectedIndex == -1)
            {
                return;
            }

            PatternDefinition source = patternList[PatternListBox.SelectedIndex];

            PatternDefinition dest
                = SettingFileAccessor.CopyPatternDefinition(Application.StartupPath, source);

            patternList.Add(dest);

            ShowPatternList();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (PatternListBox.SelectedIndex == -1)
            {
                return;
            }

            PatternDefinition target = patternList[PatternListBox.SelectedIndex];

            PatternDefinition updated = CreateEditingPattern(target);

            patternList.Insert(PatternListBox.SelectedIndex, updated);
            patternList.Remove(target);

            SettingFileAccessor.SavePatternDefinition(Application.StartupPath, updated);

            MessageBox.Show(Properties.Resources.MessageSaveSetting);

            ShowPatternList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PatternListBox.SelectedIndex == -1
                || PatternListBox.SelectedIndex > patternList.Count - 1)
            {
                return;
            }

            PatternDefinition target = patternList[PatternListBox.SelectedIndex];
            SettingFileAccessor.DeletePatternDefinition(Application.StartupPath, target);

            patternList.Remove(target);

            ShowPatternList();
        }

        #endregion

        private void PatternListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatternListBox.SelectedIndex == -1)
            {
                return;
            }

            PatternDefinition target = patternList[PatternListBox.SelectedIndex];

            ShowPatternDetail(target);
        }

        #endregion

        private void ShowPatternList()
        {
            PatternListBox.Items.Clear();

            foreach (PatternDefinition pattern in patternList)
            {
                PatternListBox.Items.Add(pattern.PatternName);
            }

            if (PatternListBox.Items.Count > 0)
            {
                PatternListBox.SelectedIndex = 0;
            }
        }

        private void ShowPatternDetail(PatternDefinition target)
        {
            PatternNameTextBox.Text = target.PatternName;
            RegexTextBox.Text = target.RegularExpression;

            ColumnDefinitionDataGrid.Rows.Clear();

            foreach (ColumnDefinition col in target.ColumnDefinitionList)
            {
                ColumnDefinitionDataGrid.Rows.Add();

                // 新規行が存在するため、Countから新規行を引いた2を指定
                DataGridViewRow row = ColumnDefinitionDataGrid.Rows[ColumnDefinitionDataGrid.Rows.Count - 2];
                row.Cells[COL_INDEX_COLUMN_NAME].Value = col.ColumnName;
                row.Cells[COL_INDEX_IS_DATETIME].Value = col.IsDateTimeField;
                row.Cells[COL_INDEX_DATETIME_FORMAT].Value = col.DateTimeFormat;
                row.Cells[COL_INDEX_VISIBLE].Value = !col.Visble;
                row.Cells[COL_INDEX_HASHABLE].Value = col.Hashable;
                row.Cells[COL_INDEX_RESIABLE].Value = col.Resizable;
            }
        }

        private PatternDefinition CreateEditingPattern(PatternDefinition target)
        {
            PatternDefinition updatedPattern = new PatternDefinition();
            updatedPattern.ID = target.ID;
            updatedPattern.PatternName = PatternNameTextBox.Text;
            updatedPattern.RegularExpression = RegexTextBox.Text;

            int order = 0;

            foreach (DataGridViewRow row in ColumnDefinitionDataGrid.Rows)
            {
                // Ignore last row because it's new row
                if (row == ColumnDefinitionDataGrid.Rows[ColumnDefinitionDataGrid.Rows.Count - 1])
                {
                    break;
                }

                ColumnDefinition col = new ColumnDefinition();
                if (row.Cells[0].Value == null)
                {
                    col.ColumnName = "";
                }
                else
                {
                    col.ColumnName = (string)row.Cells[0].Value;
                }

                if (row.Cells[COL_INDEX_IS_DATETIME].Value == null)
                {
                    col.IsDateTimeField = false;
                }
                else
                {
                    col.IsDateTimeField = (bool)row.Cells[COL_INDEX_IS_DATETIME].Value;
                }

                if (row.Cells[COL_INDEX_DATETIME_FORMAT].Value == null)
                {
                    col.DateTimeFormat = "";
                }
                else
                {
                    col.DateTimeFormat = (string)row.Cells[COL_INDEX_DATETIME_FORMAT].Value;
                }

                if (row.Cells[COL_INDEX_VISIBLE].Value == null)
                {
                    col.Visble = true;
                }
                else
                {
                    col.Visble = !(bool)row.Cells[COL_INDEX_VISIBLE].Value;
                }

                if (row.Cells[COL_INDEX_HASHABLE].Value == null)
                {
                    col.Hashable = false;
                }
                else
                {
                    col.Hashable = (bool)row.Cells[COL_INDEX_HASHABLE].Value;
                }

                if (row.Cells[COL_INDEX_RESIABLE].Value == null)
                {
                    col.Resizable = false;
                }
                else
                {
                    col.Resizable = (bool)row.Cells[COL_INDEX_RESIABLE].Value;
                }

                col.Order = order;

                updatedPattern.ColumnDefinitionList.Add(col);
                order++;
            }

            return updatedPattern;
        }
    }
}
