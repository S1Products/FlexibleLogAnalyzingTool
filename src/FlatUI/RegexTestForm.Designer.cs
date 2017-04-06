namespace FlexibleLogAnalyzingTool
{
    partial class RegexTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexTestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SampleLogTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.RegexTextbox = new System.Windows.Forms.RichTextBox();
            this.ParsedElementsListView = new System.Windows.Forms.ListView();
            this.ValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ElementCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SampleLogTextBox
            // 
            this.SampleLogTextBox.AcceptsReturn = true;
            resources.ApplyResources(this.SampleLogTextBox, "SampleLogTextBox");
            this.SampleLogTextBox.Name = "SampleLogTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // ResultListBox
            // 
            resources.ApplyResources(this.ResultListBox, "ResultListBox");
            this.ResultListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ResultListBox_DrawItem);
            this.ResultListBox.SelectedIndexChanged += new System.EventHandler(this.ResultListBox_SelectedIndexChanged);
            // 
            // EvaluateButton
            // 
            resources.ApplyResources(this.EvaluateButton, "EvaluateButton");
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // RegexTextbox
            // 
            resources.ApplyResources(this.RegexTextbox, "RegexTextbox");
            this.RegexTextbox.Name = "RegexTextbox";
            this.RegexTextbox.TextChanged += new System.EventHandler(this.RegexTextbox_TextChanged);
            // 
            // ParsedElementsListView
            // 
            resources.ApplyResources(this.ParsedElementsListView, "ParsedElementsListView");
            this.ParsedElementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValueHeader});
            this.ParsedElementsListView.GridLines = true;
            this.ParsedElementsListView.Name = "ParsedElementsListView";
            this.ParsedElementsListView.UseCompatibleStateImageBehavior = false;
            this.ParsedElementsListView.View = System.Windows.Forms.View.Details;
            // 
            // ValueHeader
            // 
            resources.ApplyResources(this.ValueHeader, "ValueHeader");
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ElementCountLabel
            // 
            resources.ApplyResources(this.ElementCountLabel, "ElementCountLabel");
            this.ElementCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ElementCountLabel.Name = "ElementCountLabel";
            // 
            // RegexTestForm
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.Controls.Add(this.ElementCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParsedElementsListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegexTextbox);
            this.Controls.Add(this.EvaluateButton);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SampleLogTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "RegexTestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SampleLogTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button EvaluateButton;
        private System.Windows.Forms.RichTextBox RegexTextbox;
        private System.Windows.Forms.ListView ParsedElementsListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader ValueHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ElementCountLabel;
    }
}