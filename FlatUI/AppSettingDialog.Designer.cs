namespace FlexibleLogAnalyzerTool
{
    partial class AppSettingDialog
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
            this.OKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayLineNumberbox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFormatTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayLineNumberbox)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(12, 99);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 27);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(99, 99);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 27);
            this.DialogCancelButton.TabIndex = 1;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "表示行数:";
            // 
            // DisplayLineNumberbox
            // 
            this.DisplayLineNumberbox.Location = new System.Drawing.Point(14, 24);
            this.DisplayLineNumberbox.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.DisplayLineNumberbox.Name = "DisplayLineNumberbox";
            this.DisplayLineNumberbox.Size = new System.Drawing.Size(160, 19);
            this.DisplayLineNumberbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "日付フォーマット:";
            // 
            // DateFormatTextbox
            // 
            this.DateFormatTextbox.Location = new System.Drawing.Point(14, 73);
            this.DateFormatTextbox.Name = "DateFormatTextbox";
            this.DateFormatTextbox.Size = new System.Drawing.Size(160, 19);
            this.DateFormatTextbox.TabIndex = 5;
            // 
            // AppSettingDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(188, 138);
            this.Controls.Add(this.DateFormatTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayLineNumberbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "アプリケーション設定";
            this.Load += new System.EventHandler(this.AppSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayLineNumberbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DisplayLineNumberbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateFormatTextbox;
    }
}