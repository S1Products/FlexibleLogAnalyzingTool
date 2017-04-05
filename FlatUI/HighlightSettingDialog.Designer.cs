namespace FlexibleLogAnalyzerTool
{
    partial class HighlightSettingDialog
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.KeywordTextbox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.HightlightColorDialog = new System.Windows.Forms.ColorDialog();
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ColumnListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HighlightListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.JumpableCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ハイライト一覧:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(369, 322);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // KeywordTextbox
            // 
            this.KeywordTextbox.Location = new System.Drawing.Point(6, 36);
            this.KeywordTextbox.Name = "KeywordTextbox";
            this.KeywordTextbox.Size = new System.Drawing.Size(163, 19);
            this.KeywordTextbox.TabIndex = 3;
            this.KeywordTextbox.TextChanged += new System.EventHandler(this.KeywordTextbox_TextChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(175, 34);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(53, 23);
            this.ColorButton.TabIndex = 4;
            this.ColorButton.Text = "色設定";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // HightlightColorDialog
            // 
            this.HightlightColorDialog.AnyColor = true;
            this.HightlightColorDialog.Color = System.Drawing.Color.LightYellow;
            this.HightlightColorDialog.FullOpen = true;
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(291, 355);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(75, 23);
            this.DialogOKButton.TabIndex = 10;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(372, 355);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DialogCancelButton.TabIndex = 11;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(207, 322);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.ItemHeight = 12;
            this.ColumnListBox.Location = new System.Drawing.Point(12, 24);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(183, 352);
            this.ColumnListBox.TabIndex = 1;
            this.ColumnListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "カラム一覧:";
            // 
            // HighlightListBox
            // 
            this.HighlightListBox.FormattingEnabled = true;
            this.HighlightListBox.ItemHeight = 12;
            this.HighlightListBox.Location = new System.Drawing.Point(207, 26);
            this.HighlightListBox.Name = "HighlightListBox";
            this.HighlightListBox.Size = new System.Drawing.Size(237, 196);
            this.HighlightListBox.TabIndex = 12;
            this.HighlightListBox.SelectedIndexChanged += new System.EventHandler(this.HighlightListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CaseSensitiveCheckBox);
            this.groupBox1.Controls.Add(this.JumpableCheckbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.KeywordTextbox);
            this.groupBox1.Controls.Add(this.ColorButton);
            this.groupBox1.Location = new System.Drawing.Point(207, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(98, 65);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(135, 16);
            this.CaseSensitiveCheckBox.TabIndex = 7;
            this.CaseSensitiveCheckBox.Text = "大文字/小文字を区別";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.CaseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.CaseSensitiveCheckBox_CheckedChanged);
            // 
            // JumpableCheckbox
            // 
            this.JumpableCheckbox.AutoSize = true;
            this.JumpableCheckbox.Location = new System.Drawing.Point(8, 65);
            this.JumpableCheckbox.Name = "JumpableCheckbox";
            this.JumpableCheckbox.Size = new System.Drawing.Size(84, 16);
            this.JumpableCheckbox.TabIndex = 6;
            this.JumpableCheckbox.Text = "ジャンプ対象";
            this.JumpableCheckbox.UseVisualStyleBackColor = true;
            this.JumpableCheckbox.CheckedChanged += new System.EventHandler(this.JumpableCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "キーワード:";
            // 
            // HighlightSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(456, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HighlightListBox);
            this.Controls.Add(this.ColumnListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HighlightSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ハイライト設定";
            this.Load += new System.EventHandler(this.HighlightSettingDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox KeywordTextbox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog HightlightColorDialog;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ColumnListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox HighlightListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox JumpableCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
    }
}