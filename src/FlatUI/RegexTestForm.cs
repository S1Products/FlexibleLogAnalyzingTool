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

using System.Text.RegularExpressions;

using FlatEngine.IntermediateLog;

namespace FlexibleLogAnalyzingTool
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Miura Acoustic</author>
    public partial class RegexTestForm : Form
    {
        private const string SEPARATOR = " | ";

        private const char CHAR_GROUP_CASE_START = '(';
        private const char CHAR_GROUP_CASE_END = ')';
        private const char CHAR_BRACKET_START = '{';
        private const char CHAR_BRACKET_END = '}';
        private const char CHAR_BIG_BRACKET_START = '[';
        private const char CHAR_BIG_BRACKET_END = ']';

        private const char CHAR_ESCAPE = '\\';

        private bool isInitialize = false;

        public RegexTestForm(string regexText)
        {
            isInitialize = true;

            InitializeComponent();
            RegexTextbox.Text = regexText;
            HighlightText();

            isInitialize = false;
        }

        public string RegularExpression
        {
            get
            {
                return RegexTextbox.Text;
            }
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();

            Regex regex = new Regex(RegexTextbox.Text);

            string[] lines = SampleLogTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                string[] elems = regex.Split(line);
                string csvline = "";

                foreach (string elem in elems)
                {
                    if (elem == "")
                    {
                        continue;
                    }

                    csvline += elem + "\a";
                }

                ResultListBox.Items.Add(csvline);
            }

            if (ResultListBox.Items.Count > 0)
            {
                ResultListBox.SelectedIndex = 0;
            }
        }

        private void ResultListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            string[] elems = txt.Split(new string[] { "\a" }, StringSplitOptions.None);

            Rectangle drawRect = e.Bounds;
            Graphics g = e.Graphics;
            Color foreColor = ResultListBox.ForeColor;

            foreach (string elem in elems)
            {
                if (elem == "")
                {
                    continue;
                }

                drawRect.Width = TextRenderer.MeasureText(g, elem, e.Font, new Size(int.MaxValue, int.MinValue), TextFormatFlags.NoPadding).Width;
                TextRenderer.DrawText(g, elem, e.Font, drawRect, foreColor, TextFormatFlags.NoPadding);
                drawRect.Location = new Point(drawRect.X + drawRect.Width, drawRect.Y);


                drawRect.Width = TextRenderer.MeasureText(g, SEPARATOR, e.Font, new Size(int.MaxValue, int.MinValue), TextFormatFlags.NoPadding).Width;
                TextRenderer.DrawText(g, SEPARATOR, e.Font, drawRect, Color.Red, TextFormatFlags.NoPadding);
                drawRect.Location = new Point(drawRect.X + drawRect.Width, drawRect.Y);
            }

            e.DrawFocusRectangle();
        }

        private void RegexTextbox_TextChanged(object sender, EventArgs e)
        {
            if (isInitialize == false)
            {
                HighlightText();
            }
        }

        private void HighlightText()
        {
            int selStart = RegexTextbox.SelectionStart;
            RegexTextbox.Enabled = false;

            string text = RegexTextbox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                char textChar = text[i];
                RegexTextbox.Select(i, 1);

                Font defaultFont = RegexTextbox.Font;

                if (i > 0 && text[i - 1] == CHAR_ESCAPE)
                {
                    RegexTextbox.SelectionColor = Color.Blue;
                    RegexTextbox.Font = defaultFont;
                    continue;
                }

                switch (textChar)
                {
                    case CHAR_GROUP_CASE_START:
                    case CHAR_GROUP_CASE_END:
                        RegexTextbox.SelectionColor = Color.Red;
                        RegexTextbox.SelectionFont = new Font(defaultFont.FontFamily,
                                                              defaultFont.Size,
                                                              defaultFont.Style | FontStyle.Bold);
                        continue;

                    case CHAR_ESCAPE:
                        RegexTextbox.SelectionColor = Color.Blue;
                        RegexTextbox.SelectionFont = defaultFont;
                        continue;

                    case CHAR_BRACKET_START:
                    case CHAR_BRACKET_END:
                    case CHAR_BIG_BRACKET_START:
                    case CHAR_BIG_BRACKET_END:
                        RegexTextbox.SelectionColor = Color.Green;
                        RegexTextbox.SelectionFont = defaultFont;
                        continue;

                    default:
                        RegexTextbox.SelectionColor = Color.Black;
                        RegexTextbox.SelectionFont = new Font(defaultFont.FontFamily,
                                                              defaultFont.Size,
                                                              defaultFont.Style | FontStyle.Bold);
                        continue;
                }
            }

            RegexTextbox.SelectionStart = selStart;
            RegexTextbox.SelectionLength = 0;
            RegexTextbox.Enabled = true;
            RegexTextbox.Focus();
        }

        private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(RegularExpression);

            ParsedElementsListView.Items.Clear();
            ElementCountLabel.Text = "";

            string txt = SampleLogTextBox.Lines[ResultListBox.SelectedIndex];
            string[] elems = regex.Split(txt);
            elems = IntermediateLogWriter.RemoveFirstAndLastEmptyElems(elems);

            foreach (string elem in elems)
            {
                ParsedElementsListView.Items.Add(elem);
            }

            ElementCountLabel.Text = elems.Length.ToString();
        }
    }
}
