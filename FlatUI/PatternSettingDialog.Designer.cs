namespace FlexibleLogAnalyzerTool
{
    partial class PatternSettingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternSettingDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.PatternListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegexTextBox = new System.Windows.Forms.TextBox();
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.ColumnDefinitionDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloneButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PatternNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateTimeFormatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibleColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HashableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ResizeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnDefinitionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PatternListBox
            // 
            resources.ApplyResources(this.PatternListBox, "PatternListBox");
            this.PatternListBox.FormattingEnabled = true;
            this.PatternListBox.Name = "PatternListBox";
            this.PatternListBox.SelectedIndexChanged += new System.EventHandler(this.PatternListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // RegexTextBox
            // 
            resources.ApplyResources(this.RegexTextBox, "RegexTextBox");
            this.RegexTextBox.Name = "RegexTextBox";
            // 
            // DialogOKButton
            // 
            resources.ApplyResources(this.DialogOKButton, "DialogOKButton");
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // ColumnDefinitionDataGrid
            // 
            resources.ApplyResources(this.ColumnDefinitionDataGrid, "ColumnDefinitionDataGrid");
            this.ColumnDefinitionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnDefinitionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateTimeColumn,
            this.DateTimeFormatColumn,
            this.VisibleColumn,
            this.HashableColumn,
            this.ResizeColumn});
            this.ColumnDefinitionDataGrid.MultiSelect = false;
            this.ColumnDefinitionDataGrid.Name = "ColumnDefinitionDataGrid";
            this.ColumnDefinitionDataGrid.RowTemplate.Height = 21;
            this.ColumnDefinitionDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ColumnDefinitionDataGrid_RowsAdded);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TestButton
            // 
            resources.ApplyResources(this.TestButton, "TestButton");
            this.TestButton.Name = "TestButton";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloneButton
            // 
            resources.ApplyResources(this.CloneButton, "CloneButton");
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // UpdateButton
            // 
            resources.ApplyResources(this.UpdateButton, "UpdateButton");
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PatternNameTextBox
            // 
            resources.ApplyResources(this.PatternNameTextBox, "PatternNameTextBox");
            this.PatternNameTextBox.Name = "PatternNameTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.NameColumn, "NameColumn");
            this.NameColumn.Name = "NameColumn";
            // 
            // DateTimeColumn
            // 
            resources.ApplyResources(this.DateTimeColumn, "DateTimeColumn");
            this.DateTimeColumn.Name = "DateTimeColumn";
            // 
            // DateTimeFormatColumn
            // 
            resources.ApplyResources(this.DateTimeFormatColumn, "DateTimeFormatColumn");
            this.DateTimeFormatColumn.Name = "DateTimeFormatColumn";
            // 
            // VisibleColumn
            // 
            resources.ApplyResources(this.VisibleColumn, "VisibleColumn");
            this.VisibleColumn.Name = "VisibleColumn";
            // 
            // HashableColumn
            // 
            resources.ApplyResources(this.HashableColumn, "HashableColumn");
            this.HashableColumn.Name = "HashableColumn";
            // 
            // ResizeColumn
            // 
            resources.ApplyResources(this.ResizeColumn, "ResizeColumn");
            this.ResizeColumn.Name = "ResizeColumn";
            this.ResizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResizeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PatternSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatternNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColumnDefinitionDataGrid);
            this.Controls.Add(this.DialogOKButton);
            this.Controls.Add(this.RegexTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatternListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PatternSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AnalyzePatternSettingDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnDefinitionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PatternListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegexTextBox;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.DataGridView ColumnDefinitionDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox PatternNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeFormatColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VisibleColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HashableColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ResizeColumn;
    }
}