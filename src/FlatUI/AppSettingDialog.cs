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

namespace FlexibleLogAnalyzerTool
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Miura Acoustic</author>
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
