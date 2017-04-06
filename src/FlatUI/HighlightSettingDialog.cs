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
    public partial class HighlightSettingDialog : Form
    {
        private ColumnDefinitionList columnDefList;
        private HighlightDefinitionList highlightDefList;

        private bool isBackground = false;

        public HighlightDefinitionList HighlightDefinitionList 
        {
            get 
            { 
                return highlightDefList; 
            } 
        }

        public HighlightSettingDialog(FlatProject project)
        {
            InitializeComponent();

            if (project == null)
            {
                return;
            }

            columnDefList = project.PatternDefinition.ColumnDefinitionList;
            highlightDefList = HighlightDefinitionList.Copy(project.HighlightDefinitionList);
        }

        private void HighlightSettingDialog_Load(object sender, EventArgs e)
        {
            ColumnListBox.Items.Clear();

            foreach (ColumnDefinition colDef in columnDefList)
            {
                if (!colDef.IsDateTimeField)
                {
                    ColumnListBox.Items.Add(colDef.ColumnName);
                }
            }

            if (ColumnListBox.Items.Count > 0)
            {
                ColumnListBox.SelectedIndex = 0;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (HightlightColorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                KeywordTextbox.BackColor = HightlightColorDialog.Color;

                HighlightDefinition def = GetTargetHighlightDef();
                if (def == null)
                {
                    return;
                }

                def.HighlightColor = KeywordTextbox.BackColor;
            }
        }

        private void ColumnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHighlightDefList();
        }

        private void ShowHighlightDefList()
        {
            List<HighlightDefinition> targetDefs = GetTargetHighlightDefList();

            if (targetDefs == null)
            {
                return;
            }

            HighlightListBox.Items.Clear();
            foreach (HighlightDefinition targetDef in targetDefs)
            {
                HighlightListBox.Items.Add(targetDef.Keyword);
            }

            if (HighlightListBox.Items.Count > 0)
            {
                HighlightListBox.SelectedIndex = 0;
            }
            else
            {
                isBackground = true;
                KeywordTextbox.Text = "";
                KeywordTextbox.BackColor = Color.LightYellow;
                JumpableCheckbox.Checked = true;
                CaseSensitiveCheckBox.Checked = false;
                isBackground = false;
            }
        }

        private void HighlightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HighlightDefinition def = GetTargetHighlightDef();

            if (def == null)
            {
                return;
            }

            isBackground = true;
            KeywordTextbox.Text = def.Keyword;
            KeywordTextbox.BackColor = def.HighlightColor;
            JumpableCheckbox.Checked = def.Jumpable;
            CaseSensitiveCheckBox.Checked = def.CaseSensitive;
            isBackground = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ColumnListBox.SelectedIndex == -1)
            {
                return;
            }

            if (KeywordTextbox.Text == "")
            {
                MessageBox.Show(Properties.Resources.NotDefinedKeyword, 
                    Properties.Resources.DialogTitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HighlightDefinition newDef = new HighlightDefinition();
            newDef.Keyword = KeywordTextbox.Text;
            newDef.HighlightColor = KeywordTextbox.BackColor;
            newDef.Jumpable = JumpableCheckbox.Checked;
            newDef.CaseSensitive = CaseSensitiveCheckBox.Checked;
            newDef.TargetColumn = GetTargetColumnDefinition();

            highlightDefList.Add(newDef);

            ShowHighlightDefList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HighlightDefinition def = GetTargetHighlightDef();

            if (def == null)
            {
                return;
            }

            highlightDefList.Remove(def);

            ShowHighlightDefList();
        }

        private void KeywordTextbox_TextChanged(object sender, EventArgs e)
        {
            HighlightDefinition def = GetTargetHighlightDef();

            if (def == null || isBackground)
            {
                return;
            }

            def.Keyword = KeywordTextbox.Text;

            HighlightListBox.Items[HighlightListBox.SelectedIndex] = KeywordTextbox.Text;
        }

        private void JumpableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HighlightDefinition def = GetTargetHighlightDef();

            if (def == null || isBackground)
            {
                return;
            }

            def.Jumpable = JumpableCheckbox.Checked;
        }

        private void CaseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HighlightDefinition def = GetTargetHighlightDef();

            if (def == null || isBackground)
            {
                return;
            }

            def.CaseSensitive = CaseSensitiveCheckBox.Checked;
        }

        private ColumnDefinition GetTargetColumnDefinition()
        {
            if (ColumnListBox.SelectedIndex == -1)
            {
                return null;
            }

            return columnDefList.Find(ColumnListBox.SelectedItem.ToString());
        }

        private List<HighlightDefinition> GetTargetHighlightDefList()
        {
            ColumnDefinition colDef = GetTargetColumnDefinition();
            return highlightDefList.Find(colDef);
        }

        private HighlightDefinition GetTargetHighlightDef()
        {
            List<HighlightDefinition> targetDefs = GetTargetHighlightDefList();

            if (targetDefs == null || HighlightListBox.SelectedIndex == -1)
            {
                return null;
            }

            return targetDefs[HighlightListBox.SelectedIndex];
        }
    }
}
