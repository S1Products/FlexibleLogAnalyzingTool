namespace FlexibleLogAnalyzingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportLogFileDialog));
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
            resources.ApplyResources(this.OpenLogFileDialog, "OpenLogFileDialog");
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.DialogOKButton, "DialogOKButton");
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.DialogCancelButton, "DialogCancelButton");
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // FilePatternTextBox
            // 
            resources.ApplyResources(this.FilePatternTextBox, "FilePatternTextBox");
            this.FilePatternTextBox.Name = "FilePatternTextBox";
            // 
            // FolderRadioButton
            // 
            resources.ApplyResources(this.FolderRadioButton, "FolderRadioButton");
            this.FolderRadioButton.Name = "FolderRadioButton";
            this.FolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileRadioButton
            // 
            resources.ApplyResources(this.FileRadioButton, "FileRadioButton");
            this.FileRadioButton.Checked = true;
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.TabStop = true;
            this.FileRadioButton.UseVisualStyleBackColor = true;
            this.FileRadioButton.CheckedChanged += new System.EventHandler(this.FileRadioButton_CheckedChanged);
            // 
            // EncodingCombobox
            // 
            this.EncodingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingCombobox.FormattingEnabled = true;
            this.EncodingCombobox.Items.AddRange(new object[] {
            resources.GetString("EncodingCombobox.Items"),
            resources.GetString("EncodingCombobox.Items1"),
            resources.GetString("EncodingCombobox.Items2")});
            resources.ApplyResources(this.EncodingCombobox, "EncodingCombobox");
            this.EncodingCombobox.Name = "EncodingCombobox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // OpenFileButton
            // 
            resources.ApplyResources(this.OpenFileButton, "OpenFileButton");
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // LogFileTextBox
            // 
            resources.ApplyResources(this.LogFileTextBox, "LogFileTextBox");
            this.LogFileTextBox.Name = "LogFileTextBox";
            // 
            // LogTitleLabel
            // 
            resources.ApplyResources(this.LogTitleLabel, "LogTitleLabel");
            this.LogTitleLabel.Name = "LogTitleLabel";
            // 
            // ImportLogFileDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
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