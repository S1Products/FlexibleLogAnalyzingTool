namespace FlexibleLogAnalyzerTool
{
    partial class FilteringRangeSettingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteringRangeSettingDialog));
            this.DialogOKButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.DateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LineNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.LogFileNameComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LineCountCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.StartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeGroupBox.SuspendLayout();
            this.LineNumberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumericUpDown)).BeginInit();
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
            // DateTimeGroupBox
            // 
            resources.ApplyResources(this.DateTimeGroupBox, "DateTimeGroupBox");
            this.DateTimeGroupBox.Controls.Add(this.DateCheckBox);
            this.DateTimeGroupBox.Controls.Add(this.label3);
            this.DateTimeGroupBox.Controls.Add(this.EndDateTimePicker);
            this.DateTimeGroupBox.Controls.Add(this.label2);
            this.DateTimeGroupBox.Controls.Add(this.StartDateTimePicker);
            this.DateTimeGroupBox.Controls.Add(this.label1);
            this.DateTimeGroupBox.Name = "DateTimeGroupBox";
            this.DateTimeGroupBox.TabStop = false;
            // 
            // DateCheckBox
            // 
            resources.ApplyResources(this.DateCheckBox, "DateCheckBox");
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // EndDateTimePicker
            // 
            resources.ApplyResources(this.EndDateTimePicker, "EndDateTimePicker");
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // StartDateTimePicker
            // 
            resources.ApplyResources(this.StartDateTimePicker, "StartDateTimePicker");
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LineNumberGroupBox
            // 
            resources.ApplyResources(this.LineNumberGroupBox, "LineNumberGroupBox");
            this.LineNumberGroupBox.Controls.Add(this.LogFileNameComboBox);
            this.LineNumberGroupBox.Controls.Add(this.label7);
            this.LineNumberGroupBox.Controls.Add(this.LineCountCheckBox);
            this.LineNumberGroupBox.Controls.Add(this.label6);
            this.LineNumberGroupBox.Controls.Add(this.EndNumericUpDown);
            this.LineNumberGroupBox.Controls.Add(this.label5);
            this.LineNumberGroupBox.Controls.Add(this.StartNumericUpDown);
            this.LineNumberGroupBox.Controls.Add(this.label4);
            this.LineNumberGroupBox.Name = "LineNumberGroupBox";
            this.LineNumberGroupBox.TabStop = false;
            // 
            // LogFileNameComboBox
            // 
            resources.ApplyResources(this.LogFileNameComboBox, "LogFileNameComboBox");
            this.LogFileNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogFileNameComboBox.FormattingEnabled = true;
            this.LogFileNameComboBox.Name = "LogFileNameComboBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // LineCountCheckBox
            // 
            resources.ApplyResources(this.LineCountCheckBox, "LineCountCheckBox");
            this.LineCountCheckBox.Name = "LineCountCheckBox";
            this.LineCountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // EndNumericUpDown
            // 
            resources.ApplyResources(this.EndNumericUpDown, "EndNumericUpDown");
            this.EndNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.EndNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumericUpDown.Name = "EndNumericUpDown";
            this.EndNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // StartNumericUpDown
            // 
            resources.ApplyResources(this.StartNumericUpDown, "StartNumericUpDown");
            this.StartNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.StartNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNumericUpDown.Name = "StartNumericUpDown";
            this.StartNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // FilteringRangeSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.Controls.Add(this.LineNumberGroupBox);
            this.Controls.Add(this.DateTimeGroupBox);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilteringRangeSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.DateTimeGroupBox.ResumeLayout(false);
            this.DateTimeGroupBox.PerformLayout();
            this.LineNumberGroupBox.ResumeLayout(false);
            this.LineNumberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DialogOKButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.GroupBox DateTimeGroupBox;
        private System.Windows.Forms.GroupBox LineNumberGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EndNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown StartNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.CheckBox LineCountCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox LogFileNameComboBox;
    }
}