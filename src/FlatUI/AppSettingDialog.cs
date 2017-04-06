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
    public partial class AppSettingDialog : Form
    {
        public AppSettingDialog()
        {
            InitializeComponent();
        }

        private void AppSettingForm_Load(object sender, EventArgs e)
        {
            DisplayLineNumberbox.Value = Properties.Settings.Default.MaxLineCount;
            DateFormatTextbox.Text = Properties.Settings.Default.DateTimeFormat;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxLineCount = (int)DisplayLineNumberbox.Value;
            Properties.Settings.Default.DateTimeFormat = DateFormatTextbox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
