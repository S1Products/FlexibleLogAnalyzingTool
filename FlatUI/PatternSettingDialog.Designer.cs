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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "解析パターン一覧:";
            // 
            // PatternListBox
            // 
            this.PatternListBox.FormattingEnabled = true;
            this.PatternListBox.ItemHeight = 12;
            this.PatternListBox.Location = new System.Drawing.Point(14, 30);
            this.PatternListBox.Name = "PatternListBox";
            this.PatternListBox.Size = new System.Drawing.Size(206, 364);
            this.PatternListBox.TabIndex = 1;
            this.PatternListBox.SelectedIndexChanged += new System.EventHandler(this.PatternListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "正規表現:";
            // 
            // RegexTextBox
            // 
            this.RegexTextBox.Location = new System.Drawing.Point(233, 67);
            this.RegexTextBox.Name = "RegexTextBox";
            this.RegexTextBox.Size = new System.Drawing.Size(535, 19);
            this.RegexTextBox.TabIndex = 9;
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(763, 400);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(75, 30);
            this.DialogOKButton.TabIndex = 13;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // ColumnDefinitionDataGrid
            // 
            this.ColumnDefinitionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnDefinitionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateTimeColumn,
            this.DateTimeFormatColumn,
            this.VisibleColumn,
            this.HashableColumn,
            this.ResizeColumn});
            this.ColumnDefinitionDataGrid.Location = new System.Drawing.Point(233, 104);
            this.ColumnDefinitionDataGrid.MultiSelect = false;
            this.ColumnDefinitionDataGrid.Name = "ColumnDefinitionDataGrid";
            this.ColumnDefinitionDataGrid.RowTemplate.Height = 21;
            this.ColumnDefinitionDataGrid.Size = new System.Drawing.Size(605, 290);
            this.ColumnDefinitionDataGrid.TabIndex = 12;
            this.ColumnDefinitionDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ColumnDefinitionDataGrid_RowsAdded);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "カラム一覧:";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(774, 65);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(64, 23);
            this.TestButton.TabIndex = 10;
            this.TestButton.Text = "テスト";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 400);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(47, 30);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(67, 400);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(47, 30);
            this.CloneButton.TabIndex = 5;
            this.CloneButton.Text = "複製";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(120, 400);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(47, 30);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(173, 400);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 30);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PatternNameTextBox
            // 
            this.PatternNameTextBox.Location = new System.Drawing.Point(233, 30);
            this.PatternNameTextBox.Name = "PatternNameTextBox";
            this.PatternNameTextBox.Size = new System.Drawing.Size(605, 19);
            this.PatternNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "パターン名:";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "名前";
            this.NameColumn.Name = "NameColumn";
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.HeaderText = "日時";
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.Width = 50;
            // 
            // DateTimeFormatColumn
            // 
            this.DateTimeFormatColumn.HeaderText = "日時フォーマット";
            this.DateTimeFormatColumn.Name = "DateTimeFormatColumn";
            this.DateTimeFormatColumn.Width = 140;
            // 
            // VisibleColumn
            // 
            this.VisibleColumn.HeaderText = "非表示";
            this.VisibleColumn.Name = "VisibleColumn";
            this.VisibleColumn.Width = 50;
            // 
            // HashableColumn
            // 
            this.HashableColumn.HeaderText = "ハッシュ化";
            this.HashableColumn.Name = "HashableColumn";
            this.HashableColumn.Width = 70;
            // 
            // ResizeColumn
            // 
            this.ResizeColumn.HeaderText = "リサイズ";
            this.ResizeColumn.Name = "ResizeColumn";
            this.ResizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResizeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ResizeColumn.Width = 70;
            // 
            // PatternSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 437);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "解析パターン設定";
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