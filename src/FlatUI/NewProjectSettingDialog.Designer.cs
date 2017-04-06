namespace FlexibleLogAnalyzingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectSettingDialog));
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
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // PatternListView
            // 
            resources.ApplyResources(this.PatternListView, "PatternListView");
            this.PatternListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatternNameHeader,
            this.Regex});
            this.PatternListView.FullRowSelect = true;
            this.PatternListView.HideSelection = false;
            this.PatternListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("PatternListView.Items")))});
            this.PatternListView.MultiSelect = false;
            this.PatternListView.Name = "PatternListView";
            this.PatternListView.UseCompatibleStateImageBehavior = false;
            this.PatternListView.View = System.Windows.Forms.View.Details;
            this.PatternListView.SelectedIndexChanged += new System.EventHandler(this.PatternListView_SelectedIndexChanged);
            // 
            // PatternNameHeader
            // 
            resources.ApplyResources(this.PatternNameHeader, "PatternNameHeader");
            // 
            // Regex
            // 
            resources.ApplyResources(this.Regex, "Regex");
            // 
            // DialogOKButton
            // 
            resources.ApplyResources(this.DialogOKButton, "DialogOKButton");
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            resources.ApplyResources(this.DialogCancelButton, "DialogCancelButton");
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // OpenLogFileDialog
            // 
            resources.ApplyResources(this.OpenLogFileDialog, "OpenLogFileDialog");
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.FilteringColumnButton);
            this.groupBox1.Controls.Add(this.FilteringRangeButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // FilteringColumnButton
            // 
            resources.ApplyResources(this.FilteringColumnButton, "FilteringColumnButton");
            this.FilteringColumnButton.Name = "FilteringColumnButton";
            this.FilteringColumnButton.UseVisualStyleBackColor = true;
            // 
            // FilteringRangeButton
            // 
            resources.ApplyResources(this.FilteringRangeButton, "FilteringRangeButton");
            this.FilteringRangeButton.Name = "FilteringRangeButton";
            this.FilteringRangeButton.UseVisualStyleBackColor = true;
            // 
            // ProjectNameTextbox
            // 
            resources.ApplyResources(this.ProjectNameTextbox, "ProjectNameTextbox");
            this.ProjectNameTextbox.Name = "ProjectNameTextbox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.FilePatternTextBox);
            this.groupBox2.Controls.Add(this.FolderRadioButton);
            this.groupBox2.Controls.Add(this.FileRadioButton);
            this.groupBox2.Controls.Add(this.EncodingCombobox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.OpenFileButton);
            this.groupBox2.Controls.Add(this.LogFileTextBox);
            this.groupBox2.Controls.Add(this.LogTitleLabel);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
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
            resources.ApplyResources(this.EncodingCombobox, "EncodingCombobox");
            this.EncodingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingCombobox.FormattingEnabled = true;
            this.EncodingCombobox.Items.AddRange(new object[] {
            resources.GetString("EncodingCombobox.Items"),
            resources.GetString("EncodingCombobox.Items1"),
            resources.GetString("EncodingCombobox.Items2")});
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
            // LogFolderBrowserDialog
            // 
            resources.ApplyResources(this.LogFolderBrowserDialog, "LogFolderBrowserDialog");
            // 
            // NewProjectSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
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