namespace FlexibleLogAnalyzerTool
{
    partial class ViewColumnSettingDialog
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
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.OrderDownButton = new System.Windows.Forms.Button();
            this.OrderUpButton = new System.Windows.Forms.Button();
            this.ColumnListBox = new System.Windows.Forms.CheckedListBox();
            this.ShowFileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(14, 332);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(84, 34);
            this.DialogOKButton.TabIndex = 0;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            this.DialogOKButton.Click += new System.EventHandler(this.DialogOKButton_Click);
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(144, 332);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(84, 34);
            this.DialogCancelButton.TabIndex = 1;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "カラム一覧:";
            // 
            // OrderDownButton
            // 
            this.OrderDownButton.AutoSize = true;
            this.OrderDownButton.Image = global::FlexibleLogAnalyzerTool.Properties.Resources.arrow_bottom_icon_24;
            this.OrderDownButton.Location = new System.Drawing.Point(228, 184);
            this.OrderDownButton.Name = "OrderDownButton";
            this.OrderDownButton.Size = new System.Drawing.Size(30, 41);
            this.OrderDownButton.TabIndex = 19;
            this.OrderDownButton.UseVisualStyleBackColor = true;
            this.OrderDownButton.Click += new System.EventHandler(this.OrderDownButton_Click);
            // 
            // OrderUpButton
            // 
            this.OrderUpButton.AutoSize = true;
            this.OrderUpButton.Image = global::FlexibleLogAnalyzerTool.Properties.Resources.arrow_top_icon_24;
            this.OrderUpButton.Location = new System.Drawing.Point(228, 95);
            this.OrderUpButton.Name = "OrderUpButton";
            this.OrderUpButton.Size = new System.Drawing.Size(30, 41);
            this.OrderUpButton.TabIndex = 18;
            this.OrderUpButton.UseVisualStyleBackColor = true;
            this.OrderUpButton.Click += new System.EventHandler(this.OrderUpButton_Click);
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Location = new System.Drawing.Point(14, 24);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(212, 284);
            this.ColumnListBox.TabIndex = 20;
            // 
            // ShowFileNameCheckBox
            // 
            this.ShowFileNameCheckBox.AutoSize = true;
            this.ShowFileNameCheckBox.Location = new System.Drawing.Point(14, 310);
            this.ShowFileNameCheckBox.Name = "ShowFileNameCheckBox";
            this.ShowFileNameCheckBox.Size = new System.Drawing.Size(103, 16);
            this.ShowFileNameCheckBox.TabIndex = 21;
            this.ShowFileNameCheckBox.Text = "ファイル名を表示";
            this.ShowFileNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewColumnSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(270, 378);
            this.Controls.Add(this.ShowFileNameCheckBox);
            this.Controls.Add(this.ColumnListBox);
            this.Controls.Add(this.OrderDownButton);
            this.Controls.Add(this.OrderUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewColumnSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "カラム表示設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button OrderDownButton;
        private System.Windows.Forms.Button OrderUpButton;
        private System.Windows.Forms.CheckedListBox ColumnListBox;
        private System.Windows.Forms.CheckBox ShowFileNameCheckBox;
    }
}