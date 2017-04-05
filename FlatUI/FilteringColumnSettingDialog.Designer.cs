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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "カラム一覧:";
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.ItemHeight = 12;
            this.ColumnListBox.Location = new System.Drawing.Point(14, 23);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(183, 328);
            this.ColumnListBox.TabIndex = 1;
            this.ColumnListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnListBox_SelectedIndexChanged);
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(491, 324);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(83, 27);
            this.DialogOKButton.TabIndex = 8;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(595, 324);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(83, 27);
            this.DialogCancelButton.TabIndex = 9;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchCriteriaDataGridView
            // 
            this.SearchCriteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchCriteriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminalColumn,
            this.OperatorColumn,
            this.ValueColumn});
            this.SearchCriteriaDataGridView.Location = new System.Drawing.Point(203, 23);
            this.SearchCriteriaDataGridView.Name = "SearchCriteriaDataGridView";
            this.SearchCriteriaDataGridView.RowTemplate.Height = 21;
            this.SearchCriteriaDataGridView.Size = new System.Drawing.Size(475, 295);
            this.SearchCriteriaDataGridView.TabIndex = 10;
            this.SearchCriteriaDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchCriteriaDataGridView_CellEndEdit);
            this.SearchCriteriaDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.SearchCriteriaDataGridView_UserAddedRow);
            this.SearchCriteriaDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SearchCriteriaDataGridView_UserDeletingRow);
            // 
            // TerminalColumn
            // 
            this.TerminalColumn.HeaderText = "And/Or";
            this.TerminalColumn.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.TerminalColumn.Name = "TerminalColumn";
            this.TerminalColumn.Width = 70;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.HeaderText = "条件";
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
            this.ValueColumn.HeaderText = "値";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "検索条件:";
            // 
            // FilteringColumnSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(693, 360);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "カラム設定";
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