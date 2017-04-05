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
            this.LineCountCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.StartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogFileNameComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimeGroupBox.SuspendLayout();
            this.LineNumberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogOKButton
            // 
            this.DialogOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogOKButton.Location = new System.Drawing.Point(177, 185);
            this.DialogOKButton.Name = "DialogOKButton";
            this.DialogOKButton.Size = new System.Drawing.Size(75, 34);
            this.DialogOKButton.TabIndex = 4;
            this.DialogOKButton.Text = "OK";
            this.DialogOKButton.UseVisualStyleBackColor = true;
            this.DialogOKButton.Click += new System.EventHandler(this.DialogOKButton_Click);
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(274, 185);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 34);
            this.DialogCancelButton.TabIndex = 5;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // DateTimeGroupBox
            // 
            this.DateTimeGroupBox.Controls.Add(this.DateCheckBox);
            this.DateTimeGroupBox.Controls.Add(this.label3);
            this.DateTimeGroupBox.Controls.Add(this.EndDateTimePicker);
            this.DateTimeGroupBox.Controls.Add(this.label2);
            this.DateTimeGroupBox.Controls.Add(this.StartDateTimePicker);
            this.DateTimeGroupBox.Controls.Add(this.label1);
            this.DateTimeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DateTimeGroupBox.Name = "DateTimeGroupBox";
            this.DateTimeGroupBox.Size = new System.Drawing.Size(337, 60);
            this.DateTimeGroupBox.TabIndex = 6;
            this.DateTimeGroupBox.TabStop = false;
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Location = new System.Drawing.Point(6, 0);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(50, 16);
            this.DateCheckBox.TabIndex = 9;
            this.DateCheckBox.Text = "日時:";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(180, 34);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(147, 19);
            this.EndDateTimePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "終了:";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(9, 34);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(148, 19);
            this.StartDateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "開始:";
            // 
            // LineNumberGroupBox
            // 
            this.LineNumberGroupBox.Controls.Add(this.LogFileNameComboBox);
            this.LineNumberGroupBox.Controls.Add(this.label7);
            this.LineNumberGroupBox.Controls.Add(this.LineCountCheckBox);
            this.LineNumberGroupBox.Controls.Add(this.label6);
            this.LineNumberGroupBox.Controls.Add(this.EndNumericUpDown);
            this.LineNumberGroupBox.Controls.Add(this.label5);
            this.LineNumberGroupBox.Controls.Add(this.StartNumericUpDown);
            this.LineNumberGroupBox.Controls.Add(this.label4);
            this.LineNumberGroupBox.Location = new System.Drawing.Point(12, 78);
            this.LineNumberGroupBox.Name = "LineNumberGroupBox";
            this.LineNumberGroupBox.Size = new System.Drawing.Size(337, 101);
            this.LineNumberGroupBox.TabIndex = 8;
            this.LineNumberGroupBox.TabStop = false;
            // 
            // LineCountCheckBox
            // 
            this.LineCountCheckBox.AutoSize = true;
            this.LineCountCheckBox.Location = new System.Drawing.Point(6, 0);
            this.LineCountCheckBox.Name = "LineCountCheckBox";
            this.LineCountCheckBox.Size = new System.Drawing.Size(62, 16);
            this.LineCountCheckBox.TabIndex = 13;
            this.LineCountCheckBox.Text = "行番号:";
            this.LineCountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "終了:";
            // 
            // EndNumericUpDown
            // 
            this.EndNumericUpDown.Location = new System.Drawing.Point(180, 66);
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
            this.EndNumericUpDown.Size = new System.Drawing.Size(147, 19);
            this.EndNumericUpDown.TabIndex = 15;
            this.EndNumericUpDown.ThousandsSeparator = true;
            this.EndNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // StartNumericUpDown
            // 
            this.StartNumericUpDown.Location = new System.Drawing.Point(10, 66);
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
            this.StartNumericUpDown.Size = new System.Drawing.Size(147, 19);
            this.StartNumericUpDown.TabIndex = 14;
            this.StartNumericUpDown.ThousandsSeparator = true;
            this.StartNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "開始:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "ログファイル名:";
            // 
            // LogFileNameComboBox
            // 
            this.LogFileNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogFileNameComboBox.FormattingEnabled = true;
            this.LogFileNameComboBox.Location = new System.Drawing.Point(85, 25);
            this.LogFileNameComboBox.Name = "LogFileNameComboBox";
            this.LogFileNameComboBox.Size = new System.Drawing.Size(242, 20);
            this.LogFileNameComboBox.TabIndex = 18;
            // 
            // FilteringRangeSettingDialog
            // 
            this.AcceptButton = this.DialogOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(364, 225);
            this.Controls.Add(this.LineNumberGroupBox);
            this.Controls.Add(this.DateTimeGroupBox);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilteringRangeSettingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "範囲設定";
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