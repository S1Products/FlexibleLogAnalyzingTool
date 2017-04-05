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
    public partial class NewProjectSettingDialog : Form
    {
        public string ProjectName
        {
            get
            {
                return ProjectNameTextbox.Text;
            }
            set
            {
                ProjectNameTextbox.Text = value;
            }
        }

        public string LogFileName
        {
            get
            {
                return LogFileTextBox.Text;
            }
            set
            {
                LogFileTextBox.Text = value;
            }
        }

        public Encoding FileEncoding
        {
            get
            {
                return Encoding.GetEncoding(EncodingCombobox.Text);
            }
        }

        public bool IsFile
        {
            get
            {
                return FileRadioButton.Checked;
            }
        }

        public string FilePattern
        {
            get
            {
                return FilePatternTextBox.Text;
            }
        }

        public List<PatternDefinition> PatternList { get; set; }

        public PatternDefinition SelectedPattern { get; set; }

        private PatternDefinition defaultPattern = PatternDefinition.CreateDefault();

        public NewProjectSettingDialog()
        {
            InitializeComponent();
            defaultPattern.ColumnDefinitionList[0].ColumnName = "メッセージ";
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (FileRadioButton.Checked)
            {
                if (OpenLogFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    LogFileTextBox.Text = OpenLogFileDialog.FileName;
                }
            }
            else
            {
                if (LogFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                {
                    LogFileTextBox.Text = LogFolderBrowserDialog.SelectedPath;
                }
            }
        }

        private void NewProjectSettingDialog_Load(object sender, EventArgs e)
        {
            EncodingCombobox.SelectedIndex = 0;
            SelectedPattern = defaultPattern;

            PatternList = SettingFileAccessor.LoadPatternDefinitionList(Application.StartupPath);

            if (PatternList != null)
            {
                foreach(PatternDefinition pattern in PatternList)
                {
                    ListViewItem item = new ListViewItem(pattern.PatternName);
                    item.SubItems.Add(pattern.RegularExpression);

                    PatternListView.Items.Add(item);
                }

                if (PatternListView.Items.Count > 0)
                {
                    PatternListView.Items[0].Selected = true;
                }
            }
        }

        private void PatternListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatternListView.SelectedIndices.Count == 0 || PatternListView.SelectedIndices[0] == 0)
            {
                this.SelectedPattern = defaultPattern;
            }
            else
            {
                // ListBoxの先頭は既定値のため、ListBoxの選択された行を-1する
                this.SelectedPattern = PatternList[PatternListView.SelectedIndices[0] - 1];
            }
        }

        private void FileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FileRadioButton.Checked)
            {
                LogTitleLabel.Text = "ログファイル名(&F):";
                FilePatternTextBox.Enabled = false;
            }
            else
            {
                LogTitleLabel.Text = "フォルダ名(&F):";
                FilePatternTextBox.Enabled = true;
            }
        }
    }
}
