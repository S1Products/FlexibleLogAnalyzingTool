﻿namespace FlexibleLogAnalyzingTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewColumnSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzingPatternSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AppSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拡張機能設定XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviousResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveFirstRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveLastRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveLineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HighlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HighlightSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JumpPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JumpNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilteringRangeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilteringColumnSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ExecutionProgressToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMessageStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalLineCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TargetLineCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayedRowNumStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StartIndexStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.LineNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleLogDataSet = new FlexibleLogAnalyzingTool.Dataset.SampleLogDataSet();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveProjectFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveExportedLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.PrintLogDialog = new System.Windows.Forms.PrintDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleLogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SettingsMenu,
            this.MoveToolStripMenuItem,
            this.HighlightToolStripMenuItem,
            this.FilteringToolStripMenuItem,
            this.ToolsMenu,
            this.helpMenu});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewProjectToolStripMenuItem,
            this.OpenProjectToolStripMenuItem,
            this.SaveProjectToolStripMenuItem,
            this.SaveAsProjectToolStripMenuItem,
            this.toolStripSeparator7,
            this.ImportLogToolStripMenuItem,
            this.ExportLogToolStripMenuItem,
            this.toolStripSeparator6,
            this.PrintLogToolStripMenuItem,
            this.toolStripSeparator5,
            this.ExitToolStripMenuItem});
            resources.ApplyResources(this.FileMenu, "FileMenu");
            this.FileMenu.Name = "FileMenu";
            // 
            // AddNewProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.AddNewProjectToolStripMenuItem, "AddNewProjectToolStripMenuItem");
            this.AddNewProjectToolStripMenuItem.Name = "AddNewProjectToolStripMenuItem";
            this.AddNewProjectToolStripMenuItem.Click += new System.EventHandler(this.AddNewProjectToolStripMenuItem_Click);
            // 
            // OpenProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.OpenProjectToolStripMenuItem, "OpenProjectToolStripMenuItem");
            this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            this.OpenProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectToolStripMenuItem_Click);
            // 
            // SaveProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.SaveProjectToolStripMenuItem, "SaveProjectToolStripMenuItem");
            this.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem";
            this.SaveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectToolStripMenuItem_Click);
            // 
            // SaveAsProjectToolStripMenuItem
            // 
            this.SaveAsProjectToolStripMenuItem.Name = "SaveAsProjectToolStripMenuItem";
            resources.ApplyResources(this.SaveAsProjectToolStripMenuItem, "SaveAsProjectToolStripMenuItem");
            this.SaveAsProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveAsProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // ImportLogToolStripMenuItem
            // 
            resources.ApplyResources(this.ImportLogToolStripMenuItem, "ImportLogToolStripMenuItem");
            this.ImportLogToolStripMenuItem.Name = "ImportLogToolStripMenuItem";
            this.ImportLogToolStripMenuItem.Click += new System.EventHandler(this.ImportLogToolStripMenuItem_Click);
            // 
            // ExportLogToolStripMenuItem
            // 
            resources.ApplyResources(this.ExportLogToolStripMenuItem, "ExportLogToolStripMenuItem");
            this.ExportLogToolStripMenuItem.Name = "ExportLogToolStripMenuItem";
            this.ExportLogToolStripMenuItem.Click += new System.EventHandler(this.ExportLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // PrintLogToolStripMenuItem
            // 
            resources.ApplyResources(this.PrintLogToolStripMenuItem, "PrintLogToolStripMenuItem");
            this.PrintLogToolStripMenuItem.Name = "PrintLogToolStripMenuItem";
            this.PrintLogToolStripMenuItem.Click += new System.EventHandler(this.PrintLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewColumnSettingToolStripMenuItem,
            this.AnalyzingPatternSettingToolStripMenuItem,
            this.toolStripSeparator2,
            this.AppSettingToolStripMenuItem,
            this.RegistExtensionToolStripMenuItem,
            this.拡張機能設定XToolStripMenuItem});
            this.SettingsMenu.Name = "SettingsMenu";
            resources.ApplyResources(this.SettingsMenu, "SettingsMenu");
            // 
            // ViewColumnSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.ViewColumnSettingToolStripMenuItem, "ViewColumnSettingToolStripMenuItem");
            this.ViewColumnSettingToolStripMenuItem.Name = "ViewColumnSettingToolStripMenuItem";
            this.ViewColumnSettingToolStripMenuItem.Click += new System.EventHandler(this.ViewColumnSettingToolStripMenuItem_Click);
            // 
            // AnalyzingPatternSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.AnalyzingPatternSettingToolStripMenuItem, "AnalyzingPatternSettingToolStripMenuItem");
            this.AnalyzingPatternSettingToolStripMenuItem.Name = "AnalyzingPatternSettingToolStripMenuItem";
            this.AnalyzingPatternSettingToolStripMenuItem.Click += new System.EventHandler(this.AnalyzingSettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // AppSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.AppSettingToolStripMenuItem, "AppSettingToolStripMenuItem");
            this.AppSettingToolStripMenuItem.Name = "AppSettingToolStripMenuItem";
            this.AppSettingToolStripMenuItem.Click += new System.EventHandler(this.AppSettingToolStripMenuItem_Click);
            // 
            // RegistExtensionToolStripMenuItem
            // 
            this.RegistExtensionToolStripMenuItem.Name = "RegistExtensionToolStripMenuItem";
            resources.ApplyResources(this.RegistExtensionToolStripMenuItem, "RegistExtensionToolStripMenuItem");
            this.RegistExtensionToolStripMenuItem.Click += new System.EventHandler(this.RegistExtensionToolStripMenuItem_Click);
            // 
            // 拡張機能設定XToolStripMenuItem
            // 
            resources.ApplyResources(this.拡張機能設定XToolStripMenuItem, "拡張機能設定XToolStripMenuItem");
            this.拡張機能設定XToolStripMenuItem.Name = "拡張機能設定XToolStripMenuItem";
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviousResultToolStripMenuItem,
            this.NextResultToolStripMenuItem,
            this.toolStripSeparator1,
            this.MoveFirstRowToolStripMenuItem,
            this.MoveLastRowToolStripMenuItem,
            this.MoveLineNumberToolStripMenuItem});
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            resources.ApplyResources(this.MoveToolStripMenuItem, "MoveToolStripMenuItem");
            // 
            // PreviousResultToolStripMenuItem
            // 
            this.PreviousResultToolStripMenuItem.Name = "PreviousResultToolStripMenuItem";
            resources.ApplyResources(this.PreviousResultToolStripMenuItem, "PreviousResultToolStripMenuItem");
            this.PreviousResultToolStripMenuItem.Click += new System.EventHandler(this.PreviousResultToolStripMenuItem_Click);
            // 
            // NextResultToolStripMenuItem
            // 
            this.NextResultToolStripMenuItem.Name = "NextResultToolStripMenuItem";
            resources.ApplyResources(this.NextResultToolStripMenuItem, "NextResultToolStripMenuItem");
            this.NextResultToolStripMenuItem.Click += new System.EventHandler(this.NextResultToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // MoveFirstRowToolStripMenuItem
            // 
            this.MoveFirstRowToolStripMenuItem.Name = "MoveFirstRowToolStripMenuItem";
            resources.ApplyResources(this.MoveFirstRowToolStripMenuItem, "MoveFirstRowToolStripMenuItem");
            this.MoveFirstRowToolStripMenuItem.Click += new System.EventHandler(this.MoveFirstRowToolStripMenuItem_Click);
            // 
            // MoveLastRowToolStripMenuItem
            // 
            this.MoveLastRowToolStripMenuItem.Name = "MoveLastRowToolStripMenuItem";
            resources.ApplyResources(this.MoveLastRowToolStripMenuItem, "MoveLastRowToolStripMenuItem");
            this.MoveLastRowToolStripMenuItem.Click += new System.EventHandler(this.MoveLastRowToolStripMenuItem_Click);
            // 
            // MoveLineNumberToolStripMenuItem
            // 
            this.MoveLineNumberToolStripMenuItem.Name = "MoveLineNumberToolStripMenuItem";
            resources.ApplyResources(this.MoveLineNumberToolStripMenuItem, "MoveLineNumberToolStripMenuItem");
            this.MoveLineNumberToolStripMenuItem.Click += new System.EventHandler(this.MoveLineNumberToolStripMenuItem_Click);
            // 
            // HighlightToolStripMenuItem
            // 
            this.HighlightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HighlightSettingToolStripMenuItem,
            this.JumpPreviousToolStripMenuItem,
            this.JumpNextToolStripMenuItem});
            this.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem";
            resources.ApplyResources(this.HighlightToolStripMenuItem, "HighlightToolStripMenuItem");
            // 
            // HighlightSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.HighlightSettingToolStripMenuItem, "HighlightSettingToolStripMenuItem");
            this.HighlightSettingToolStripMenuItem.Name = "HighlightSettingToolStripMenuItem";
            this.HighlightSettingToolStripMenuItem.Click += new System.EventHandler(this.HighlightSettingToolStripMenuItem_Click);
            // 
            // JumpPreviousToolStripMenuItem
            // 
            resources.ApplyResources(this.JumpPreviousToolStripMenuItem, "JumpPreviousToolStripMenuItem");
            this.JumpPreviousToolStripMenuItem.Name = "JumpPreviousToolStripMenuItem";
            this.JumpPreviousToolStripMenuItem.Click += new System.EventHandler(this.JumpPreviousToolStripMenuItem_Click);
            // 
            // JumpNextToolStripMenuItem
            // 
            resources.ApplyResources(this.JumpNextToolStripMenuItem, "JumpNextToolStripMenuItem");
            this.JumpNextToolStripMenuItem.Name = "JumpNextToolStripMenuItem";
            this.JumpNextToolStripMenuItem.Click += new System.EventHandler(this.JumpNextToolStripMenuItem_Click);
            // 
            // FilteringToolStripMenuItem
            // 
            this.FilteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilteringRangeSettingToolStripMenuItem,
            this.FilteringColumnSettingToolStripMenuItem});
            this.FilteringToolStripMenuItem.Name = "FilteringToolStripMenuItem";
            resources.ApplyResources(this.FilteringToolStripMenuItem, "FilteringToolStripMenuItem");
            // 
            // FilteringRangeSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.FilteringRangeSettingToolStripMenuItem, "FilteringRangeSettingToolStripMenuItem");
            this.FilteringRangeSettingToolStripMenuItem.Name = "FilteringRangeSettingToolStripMenuItem";
            this.FilteringRangeSettingToolStripMenuItem.Click += new System.EventHandler(this.FilteringRangeSettingToolStripMenuItem_Click);
            // 
            // FilteringColumnSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.FilteringColumnSettingToolStripMenuItem, "FilteringColumnSettingToolStripMenuItem");
            this.FilteringColumnSettingToolStripMenuItem.Name = "FilteringColumnSettingToolStripMenuItem";
            this.FilteringColumnSettingToolStripMenuItem.Click += new System.EventHandler(this.FilteringColumnSettingToolStripMenuItem_Click);
            // 
            // ToolsMenu
            // 
            resources.ApplyResources(this.ToolsMenu, "ToolsMenu");
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            resources.ApplyResources(this.helpMenu, "helpMenu");
            // 
            // AboutToolStripMenuItem
            // 
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecutionProgressToolStrip,
            this.toolStripStatusLabel2,
            this.StatusMessageStripStatusLabel,
            this.toolStripStatusLabel5,
            this.TotalLineCountToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.TargetLineCountToolStripStatusLabel,
            this.toolStripStatusLabel4,
            this.DisplayedRowNumStripStatusLabel,
            this.toolStripStatusLabel1,
            this.StartIndexStripStatusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // ExecutionProgressToolStrip
            // 
            this.ExecutionProgressToolStrip.Name = "ExecutionProgressToolStrip";
            resources.ApplyResources(this.ExecutionProgressToolStrip, "ExecutionProgressToolStrip");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // StatusMessageStripStatusLabel
            // 
            this.StatusMessageStripStatusLabel.Name = "StatusMessageStripStatusLabel";
            resources.ApplyResources(this.StatusMessageStripStatusLabel, "StatusMessageStripStatusLabel");
            this.StatusMessageStripStatusLabel.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            resources.ApplyResources(this.toolStripStatusLabel5, "toolStripStatusLabel5");
            // 
            // TotalLineCountToolStripStatusLabel
            // 
            this.TotalLineCountToolStripStatusLabel.Name = "TotalLineCountToolStripStatusLabel";
            resources.ApplyResources(this.TotalLineCountToolStripStatusLabel, "TotalLineCountToolStripStatusLabel");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // TargetLineCountToolStripStatusLabel
            // 
            this.TargetLineCountToolStripStatusLabel.Name = "TargetLineCountToolStripStatusLabel";
            resources.ApplyResources(this.TargetLineCountToolStripStatusLabel, "TargetLineCountToolStripStatusLabel");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // DisplayedRowNumStripStatusLabel
            // 
            this.DisplayedRowNumStripStatusLabel.Name = "DisplayedRowNumStripStatusLabel";
            resources.ApplyResources(this.DisplayedRowNumStripStatusLabel, "DisplayedRowNumStripStatusLabel");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // StartIndexStripStatusLabel
            // 
            this.StartIndexStripStatusLabel.Name = "StartIndexStripStatusLabel";
            resources.ApplyResources(this.StartIndexStripStatusLabel, "StartIndexStripStatusLabel");
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.AllowUserToDeleteRows = false;
            this.LogDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNumColumn,
            this.MessageColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.LogDataGridView, "LogDataGridView");
            this.LogDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.RowHeadersVisible = false;
            this.LogDataGridView.RowTemplate.Height = 21;
            this.LogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.LogDataGridView_CellPainting);
            this.LogDataGridView.Resize += new System.EventHandler(this.LogDataGridView_Resize);
            // 
            // LineNumColumn
            // 
            resources.ApplyResources(this.LineNumColumn, "LineNumColumn");
            this.LineNumColumn.Name = "LineNumColumn";
            this.LineNumColumn.ReadOnly = true;
            this.LineNumColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MessageColumn
            // 
            this.MessageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.MessageColumn, "MessageColumn");
            this.MessageColumn.Name = "MessageColumn";
            this.MessageColumn.ReadOnly = true;
            // 
            // sampleLogBindingSource
            // 
            this.sampleLogBindingSource.DataMember = "SampleLog";
            this.sampleLogBindingSource.DataSource = this.sampleLogDataSet;
            // 
            // sampleLogDataSet
            // 
            this.sampleLogDataSet.DataSetName = "SampleLogDataSet";
            this.sampleLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OpenProjectFileDialog
            // 
            resources.ApplyResources(this.OpenProjectFileDialog, "OpenProjectFileDialog");
            // 
            // SaveProjectFileDialog
            // 
            resources.ApplyResources(this.SaveProjectFileDialog, "SaveProjectFileDialog");
            // 
            // SaveExportedLogFileDialog
            // 
            resources.ApplyResources(this.SaveExportedLogFileDialog, "SaveExportedLogFileDialog");
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // PrintLogDialog
            // 
            this.PrintLogDialog.AllowSelection = true;
            this.PrintLogDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogDataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleLogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem PrintLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripProgressBar ExecutionProgressToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel TotalLineCountToolStripStatusLabel;
        private System.Windows.Forms.DataGridView LogDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem FilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilteringRangeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilteringColumnSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HighlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HighlightSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JumpNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JumpPreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnalyzingPatternSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewColumnSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource sampleLogBindingSource;
        private Dataset.SampleLogDataSet sampleLogDataSet;
        private System.Windows.Forms.ToolStripMenuItem 拡張機能設定XToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem AddNewProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportLogToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenProjectFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveProjectFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveExportedLogFileDialog;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveFirstRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveLastRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveLineNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessageStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.ToolStripMenuItem PreviousResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StartIndexStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel DisplayedRowNumStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ImportLogToolStripMenuItem;
        private System.Windows.Forms.PrintDialog PrintLogDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TargetLineCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem RegistExtensionToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
    }
}



