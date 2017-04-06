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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingDialog));
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
            resources.ApplyResources(this.OKButton, "OKButton");
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Name = "OKButton";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DialogCancelButton
            // 
            resources.ApplyResources(this.DialogCancelButton, "DialogCancelButton");
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DisplayLineNumberbox
            // 
            resources.ApplyResources(this.DisplayLineNumberbox, "DisplayLineNumberbox");
            this.DisplayLineNumberbox.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.DisplayLineNumberbox.Name = "DisplayLineNumberbox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // DateFormatTextbox
            // 
            resources.ApplyResources(this.DateFormatTextbox, "DateFormatTextbox");
            this.DateFormatTextbox.Name = "DateFormatTextbox";
            // 
            // AppSettingDialog
            // 
            this.AcceptButton = this.OKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
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