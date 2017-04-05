using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexibleLogAnalyzerTool
{
    public partial class ImportLogFileDialog : Form
    {
        public ImportLogFileDialog()
        {
            InitializeComponent();
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

        private void ImportLogFileDialog_Load(object sender, EventArgs e)
        {
            EncodingCombobox.SelectedIndex = 0;
        }
    }
}
