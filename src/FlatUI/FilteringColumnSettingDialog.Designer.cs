namespace FlexibleLogAnalyzerTool
{
    partial class FilteringColumnSettingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteringColumnSettingDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnListBox = new System.Windows.Forms.ListBox();
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.SearchCriteriaDataGridView = new System.Windows.Forms.DataGridView();
            this.TerminalColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCriteriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ColumnListBox, "ColumnListBox");
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnListBox_SelectedIndexChanged);
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
            // SearchCriteriaDataGridView
            // 
            this.SearchCriteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchCriteriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminalColumn,
            this.OperatorColumn,
            this.ValueColumn});
            resources.ApplyResources(this.SearchCriteriaDataGridView, "SearchCriteriaDataGridView");
            this.SearchCriteriaDataGridView.Name = "SearchCriteriaDataGridView";
            this.SearchCriteriaDataGridView.RowTemplate.Height = 21;
            this.SearchCriteriaDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchCriteriaDataGridView_CellEndEdit);
            this.SearchCriteriaDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.SearchCriteriaDataGridView_UserAddedRow);
            this.SearchCriteriaDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SearchCriteriaDataGridView_UserDeletingRow);
            // 
            // TerminalColumn
            // 
            resources.ApplyResources(this.TerminalColumn, "TerminalColumn");
            this.TerminalColumn.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.TerminalColumn.Name = "TerminalColumn";
            // 
            // OperatorColumn
            // 
            resources.ApplyResources(this.OperatorColumn, "OperatorColumn");
            this.OperatorColumn.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "Like",
            "NotLike"});
            this.OperatorColumn.Name = "OperatorColumn";
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ValueColumn, "ValueColumn");
            this.ValueColumn.Name = "ValueColumn";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FilteringColumnSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.Controls.Add(this.SearchCriteriaDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.Controls.Add(this.ColumnListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilteringColumnSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.SearchCriteriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ColumnListBox;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.DataGridView SearchCriteriaDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn TerminalColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
    }
}