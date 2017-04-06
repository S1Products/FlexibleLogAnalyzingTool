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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewColumnSettingDialog));
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ColumnListBox = new System.Windows.Forms.CheckedListBox();
            this.ShowFileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderDownButton = new System.Windows.Forms.Button();
            this.OrderUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DialogOKButton
            // 
            resources.ApplyResources(this.DialogOKButton, "DialogOKButton");
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            this.DialogOKButton.Click += new System.EventHandler(this.DialogOKButton_Click);
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
            // ColumnListBox
            // 
            resources.ApplyResources(this.ColumnListBox, "ColumnListBox");
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Name = "ColumnListBox";
            // 
            // ShowFileNameCheckBox
            // 
            resources.ApplyResources(this.ShowFileNameCheckBox, "ShowFileNameCheckBox");
            this.ShowFileNameCheckBox.Name = "ShowFileNameCheckBox";
            this.ShowFileNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderDownButton
            // 
            resources.ApplyResources(this.OrderDownButton, "OrderDownButton");
            this.OrderDownButton.Image = global::FlexibleLogAnalyzerTool.Properties.Resources.arrow_bottom_icon_24;
            this.OrderDownButton.Name = "OrderDownButton";
            this.OrderDownButton.UseVisualStyleBackColor = true;
            this.OrderDownButton.Click += new System.EventHandler(this.OrderDownButton_Click);
            // 
            // OrderUpButton
            // 
            resources.ApplyResources(this.OrderUpButton, "OrderUpButton");
            this.OrderUpButton.Image = global::FlexibleLogAnalyzerTool.Properties.Resources.arrow_top_icon_24;
            this.OrderUpButton.Name = "OrderUpButton";
            this.OrderUpButton.UseVisualStyleBackColor = true;
            this.OrderUpButton.Click += new System.EventHandler(this.OrderUpButton_Click);
            // 
            // ViewColumnSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
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