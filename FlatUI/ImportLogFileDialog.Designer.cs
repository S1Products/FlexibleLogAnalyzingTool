namespace FlexibleLogAnalyzerTool
{
    partial class ImportLogFileDialog
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
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.FilePatternTextBox = new System.Windows.Forms.TextBox();
            this.FolderRadioButton = new System.Windows.Forms.RadioButton();
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.EncodingCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.LogFileTextBox = new System.Windows.Forms.TextBox();
            this.LogTitleLabel = new System.Windows.Forms.Label();
            this.LogFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // OpenLogFileDialog
            // 
            this.OpenLogFileDialog.Filter = "すべてのファイル (*.*)|*.*";
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(236, 65);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(75, 32);
            this.DialogOKButton.TabIndex = 8;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(333, 65);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 32);
            this.DialogCancelButton.TabIndex = 9;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // FilePatternTextBox
            // 
            this.FilePatternTextBox.Enabled = false;
            this.FilePatternTextBox.Location = new System.Drawing.Point(299, 6);
            this.FilePatternTextBox.Name = "FilePatternTextBox";
            this.FilePatternTextBox.Size = new System.Drawing.Size(81, 19);
            this.FilePatternTextBox.TabIndex = 2;
            this.FilePatternTextBox.Text = "*.log";
            // 
            // FolderRadioButton
            // 
            this.FolderRadioButton.AutoSize = true;
            this.FolderRadioButton.Location = new System.Drawing.Point(211, 7);
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
            this.FileRadioButton.Location = new System.Drawing.Point(119, 7);
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
            this.EncodingCombobox.Location = new System.Drawing.Point(12, 72);
            this.EncodingCombobox.Name = "EncodingCombobox";
            this.EncodingCombobox.Size = new System.Drawing.Size(87, 20);
            this.EncodingCombobox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "文字コード(&C):";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(386, 27);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(22, 23);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "..";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // LogFileTextBox
            // 
            this.LogFileTextBox.Location = new System.Drawing.Point(12, 29);
            this.LogFileTextBox.Name = "LogFileTextBox";
            this.LogFileTextBox.Size = new System.Drawing.Size(368, 19);
            this.LogFileTextBox.TabIndex = 4;
            // 
            // LogTitleLabel
            // 
            this.LogTitleLabel.AutoSize = true;
            this.LogTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.LogTitleLabel.Name = "LogTitleLabel";
            this.LogTitleLabel.Size = new System.Drawing.Size(86, 12);
            this.LogTitleLabel.TabIndex = 3;
            this.LogTitleLabel.Text = "ログファイル名(&F):";
            // 
            // ImportLogFileDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(417, 104);
            this.Controls.Add(this.FilePatternTextBox);
            this.Controls.Add(this.FolderRadioButton);
            this.Controls.Add(this.FileRadioButton);
            this.Controls.Add(this.EncodingCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.LogFileTextBox);
            this.Controls.Add(this.LogTitleLabel);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportLogFileDialog";
            this.Text = "ログファイルのインポート";
            this.Load += new System.EventHandler(this.ImportLogFileDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenLogFileDialog;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.TextBox FilePatternTextBox;
        private System.Windows.Forms.RadioButton FolderRadioButton;
        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.ComboBox EncodingCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox LogFileTextBox;
        private System.Windows.Forms.Label LogTitleLabel;
        private System.Windows.Forms.FolderBrowserDialog LogFolderBrowserDialog;

    }
}