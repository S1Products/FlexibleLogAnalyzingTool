namespace FlexibleLogAnalyzerTool
{
    partial class NewProjectSettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "既定値",
            "#定義なし"}, -1);
            this.label2 = new System.Windows.Forms.Label();
            this.PatternListView = new System.Windows.Forms.ListView();
            this.PatternNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Regex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilteringColumnButton = new System.Windows.Forms.Button();
            this.FilteringRangeButton = new System.Windows.Forms.Button();
            this.ProjectNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilePatternTextBox = new System.Windows.Forms.TextBox();
            this.FolderRadioButton = new System.Windows.Forms.RadioButton();
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.EncodingCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.LogFileTextBox = new System.Windows.Forms.TextBox();
            this.LogTitleLabel = new System.Windows.Forms.Label();
            this.LogFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "解析パターン(&P):";
            // 
            // PatternListView
            // 
            this.PatternListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatternNameHeader,
            this.Regex});
            this.PatternListView.FullRowSelect = true;
            this.PatternListView.HideSelection = false;
            this.PatternListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.PatternListView.Location = new System.Drawing.Point(14, 139);
            this.PatternListView.MultiSelect = false;
            this.PatternListView.Name = "PatternListView";
            this.PatternListView.Size = new System.Drawing.Size(508, 133);
            this.PatternListView.TabIndex = 4;
            this.PatternListView.UseCompatibleStateImageBehavior = false;
            this.PatternListView.View = System.Windows.Forms.View.Details;
            this.PatternListView.SelectedIndexChanged += new System.EventHandler(this.PatternListView_SelectedIndexChanged);
            // 
            // PatternNameHeader
            // 
            this.PatternNameHeader.Text = "パターン名";
            this.PatternNameHeader.Width = 194;
            // 
            // Regex
            // 
            this.Regex.Text = "正規表現";
            this.Regex.Width = 305;
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(318, 295);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(93, 35);
            this.DialogOKButton.TabIndex = 6;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(429, 295);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(93, 35);
            this.DialogCancelButton.TabIndex = 7;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // OpenLogFileDialog
            // 
            this.OpenLogFileDialog.Filter = "すべてのファイル (*.*)|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilteringColumnButton);
            this.groupBox1.Controls.Add(this.FilteringRangeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "フィルタリング設定:";
            // 
            // FilteringColumnButton
            // 
            this.FilteringColumnButton.Location = new System.Drawing.Point(92, 23);
            this.FilteringColumnButton.Name = "FilteringColumnButton";
            this.FilteringColumnButton.Size = new System.Drawing.Size(75, 23);
            this.FilteringColumnButton.TabIndex = 1;
            this.FilteringColumnButton.Text = "カラム設定";
            this.FilteringColumnButton.UseVisualStyleBackColor = true;
            // 
            // FilteringRangeButton
            // 
            this.FilteringRangeButton.Location = new System.Drawing.Point(11, 23);
            this.FilteringRangeButton.Name = "FilteringRangeButton";
            this.FilteringRangeButton.Size = new System.Drawing.Size(75, 23);
            this.FilteringRangeButton.TabIndex = 0;
            this.FilteringRangeButton.Text = "範囲指定";
            this.FilteringRangeButton.UseVisualStyleBackColor = true;
            // 
            // ProjectNameTextbox
            // 
            this.ProjectNameTextbox.Location = new System.Drawing.Point(14, 24);
            this.ProjectNameTextbox.Name = "ProjectNameTextbox";
            this.ProjectNameTextbox.Size = new System.Drawing.Size(508, 19);
            this.ProjectNameTextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "プロジェクト名(&N):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilePatternTextBox);
            this.groupBox2.Controls.Add(this.FolderRadioButton);
            this.groupBox2.Controls.Add(this.FileRadioButton);
            this.groupBox2.Controls.Add(this.EncodingCombobox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.OpenFileButton);
            this.groupBox2.Controls.Add(this.LogFileTextBox);
            this.groupBox2.Controls.Add(this.LogTitleLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ログ設定";
            // 
            // FilePatternTextBox
            // 
            this.FilePatternTextBox.Enabled = false;
            this.FilePatternTextBox.Location = new System.Drawing.Point(298, 16);
            this.FilePatternTextBox.Name = "FilePatternTextBox";
            this.FilePatternTextBox.Size = new System.Drawing.Size(81, 19);
            this.FilePatternTextBox.TabIndex = 2;
            this.FilePatternTextBox.Text = "*.log";
            // 
            // FolderRadioButton
            // 
            this.FolderRadioButton.AutoSize = true;
            this.FolderRadioButton.Location = new System.Drawing.Point(210, 17);
            this.FolderRadioButton.Name = "FolderRadioButton";
            this.FolderRadioButton.Size = new System.Drawing.Size(82, 16);
            this.FolderRadioButton.TabIndex = 1;
            this.FolderRadioButton.Text = "フォルダ単位";
            this.FolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileRadioButton
            // 
            this.FileRadioButton.AutoSize = true;
            this.FileRadioButton.Checked = true;
            this.FileRadioButton.Location = new System.Drawing.Point(123, 17);
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.Size = new System.Drawing.Size(81, 16);
            this.FileRadioButton.TabIndex = 0;
            this.FileRadioButton.TabStop = true;
            this.FileRadioButton.Text = "ファイル単位";
            this.FileRadioButton.UseVisualStyleBackColor = true;
            this.FileRadioButton.CheckedChanged += new System.EventHandler(this.FileRadioButton_CheckedChanged);
            // 
            // EncodingCombobox
            // 
            this.EncodingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingCombobox.FormattingEnabled = true;
            this.EncodingCombobox.Items.AddRange(new object[] {
            "UTF-8",
            "Shift_JIS",
            "EUC-JP"});
            this.EncodingCombobox.Location = new System.Drawing.Point(417, 37);
            this.EncodingCombobox.Name = "EncodingCombobox";
            this.EncodingCombobox.Size = new System.Drawing.Size(87, 20);
            this.EncodingCombobox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "文字コード(&C):";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(385, 35);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(22, 23);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "..";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // LogFileTextBox
            // 
            this.LogFileTextBox.Location = new System.Drawing.Point(11, 39);
            this.LogFileTextBox.Name = "LogFileTextBox";
            this.LogFileTextBox.Size = new System.Drawing.Size(368, 19);
            this.LogFileTextBox.TabIndex = 4;
            // 
            // LogTitleLabel
            // 
            this.LogTitleLabel.AutoSize = true;
            this.LogTitleLabel.Location = new System.Drawing.Point(9, 21);
            this.LogTitleLabel.Name = "LogTitleLabel";
            this.LogTitleLabel.Size = new System.Drawing.Size(86, 12);
            this.LogTitleLabel.TabIndex = 3;
            this.LogTitleLabel.Text = "ログファイル名(&F):";
            // 
            // NewProjectSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(534, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProjectNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.Controls.Add(this.PatternListView);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NewProjectSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新規プロジェクト";
            this.Load += new System.EventHandler(this.NewProjectSettingDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView PatternListView;
        private System.Windows.Forms.ColumnHeader PatternNameHeader;
        private System.Windows.Forms.ColumnHeader Regex;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.OpenFileDialog OpenLogFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FilteringColumnButton;
        private System.Windows.Forms.Button FilteringRangeButton;
        private System.Windows.Forms.TextBox ProjectNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FolderRadioButton;
        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.ComboBox EncodingCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox LogFileTextBox;
        private System.Windows.Forms.Label LogTitleLabel;
        private System.Windows.Forms.FolderBrowserDialog LogFolderBrowserDialog;
        private System.Windows.Forms.TextBox FilePatternTextBox;
    }
}