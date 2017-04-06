namespace FlexibleLogAnalyzingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighlightSettingDialog));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // KeywordTextbox
            // 
            resources.ApplyResources(this.KeywordTextbox, "KeywordTextbox");
            this.KeywordTextbox.Name = "KeywordTextbox";
            this.KeywordTextbox.TextChanged += new System.EventHandler(this.KeywordTextbox_TextChanged);
            // 
            // ColorButton
            // 
            resources.ApplyResources(this.ColorButton, "ColorButton");
            this.ColorButton.Name = "ColorButton";
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
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ColumnListBox
            // 
            resources.ApplyResources(this.ColumnListBox, "ColumnListBox");
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // HighlightListBox
            // 
            resources.ApplyResources(this.HighlightListBox, "HighlightListBox");
            this.HighlightListBox.FormattingEnabled = true;
            this.HighlightListBox.Name = "HighlightListBox";
            this.HighlightListBox.SelectedIndexChanged += new System.EventHandler(this.HighlightListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.CaseSensitiveCheckBox);
            this.groupBox1.Controls.Add(this.JumpableCheckbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.KeywordTextbox);
            this.groupBox1.Controls.Add(this.ColorButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CaseSensitiveCheckBox
            // 
            resources.ApplyResources(this.CaseSensitiveCheckBox, "CaseSensitiveCheckBox");
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.CaseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.CaseSensitiveCheckBox_CheckedChanged);
            // 
            // JumpableCheckbox
            // 
            resources.ApplyResources(this.JumpableCheckbox, "JumpableCheckbox");
            this.JumpableCheckbox.Name = "JumpableCheckbox";
            this.JumpableCheckbox.UseVisualStyleBackColor = true;
            this.JumpableCheckbox.CheckedChanged += new System.EventHandler(this.JumpableCheckbox_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // HighlightSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
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