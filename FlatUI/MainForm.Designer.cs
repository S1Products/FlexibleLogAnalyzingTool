namespace FlexibleLogAnalyzerTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.sampleLogDataSet = new FlexibleLogAnalyzerTool.Dataset.SampleLogDataSet();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveProjectFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveExportedLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.PrintLogDialog = new System.Windows.Forms.PrintDialog();
            this.RegistExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1010, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
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
            this.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(85, 22);
            this.FileMenu.Text = "ファイル(&F)";
            // 
            // AddNewProjectToolStripMenuItem
            // 
            this.AddNewProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddNewProjectToolStripMenuItem.Image")));
            this.AddNewProjectToolStripMenuItem.Name = "AddNewProjectToolStripMenuItem";
            this.AddNewProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddNewProjectToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.AddNewProjectToolStripMenuItem.Text = "プロジェクトの新規作成(&N)";
            this.AddNewProjectToolStripMenuItem.Click += new System.EventHandler(this.AddNewProjectToolStripMenuItem_Click);
            // 
            // OpenProjectToolStripMenuItem
            // 
            this.OpenProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenProjectToolStripMenuItem.Image")));
            this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            this.OpenProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenProjectToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.OpenProjectToolStripMenuItem.Text = "プロジェクトを開く(&O)";
            this.OpenProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectToolStripMenuItem_Click);
            // 
            // SaveProjectToolStripMenuItem
            // 
            this.SaveProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveProjectToolStripMenuItem.Image")));
            this.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem";
            this.SaveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveProjectToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.SaveProjectToolStripMenuItem.Text = "プロジェクトの保存(&S)";
            this.SaveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectToolStripMenuItem_Click);
            // 
            // SaveAsProjectToolStripMenuItem
            // 
            this.SaveAsProjectToolStripMenuItem.Name = "SaveAsProjectToolStripMenuItem";
            this.SaveAsProjectToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.SaveAsProjectToolStripMenuItem.Text = "名前を付けてプロジェクトを保存(&A)";
            this.SaveAsProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveAsProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(272, 6);
            // 
            // ImportLogToolStripMenuItem
            // 
            this.ImportLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ImportLogToolStripMenuItem.Image")));
            this.ImportLogToolStripMenuItem.Name = "ImportLogToolStripMenuItem";
            this.ImportLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ImportLogToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.ImportLogToolStripMenuItem.Text = "ログをインポート(&I)";
            this.ImportLogToolStripMenuItem.Click += new System.EventHandler(this.ImportLogToolStripMenuItem_Click);
            // 
            // ExportLogToolStripMenuItem
            // 
            this.ExportLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExportLogToolStripMenuItem.Image")));
            this.ExportLogToolStripMenuItem.Name = "ExportLogToolStripMenuItem";
            this.ExportLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExportLogToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.ExportLogToolStripMenuItem.Text = "ログをエクスポート(&E)";
            this.ExportLogToolStripMenuItem.Click += new System.EventHandler(this.ExportLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(272, 6);
            // 
            // PrintLogToolStripMenuItem
            // 
            this.PrintLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintLogToolStripMenuItem.Image")));
            this.PrintLogToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.PrintLogToolStripMenuItem.Name = "PrintLogToolStripMenuItem";
            this.PrintLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintLogToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.PrintLogToolStripMenuItem.Text = "印刷(&P)";
            this.PrintLogToolStripMenuItem.Click += new System.EventHandler(this.PrintLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(272, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.ExitToolStripMenuItem.Text = "アプリケーションの終了(&X)";
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
            this.SettingsMenu.Size = new System.Drawing.Size(63, 22);
            this.SettingsMenu.Text = "設定(&N)";
            // 
            // ViewColumnSettingToolStripMenuItem
            // 
            this.ViewColumnSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ViewColumnSettingToolStripMenuItem.Image")));
            this.ViewColumnSettingToolStripMenuItem.Name = "ViewColumnSettingToolStripMenuItem";
            this.ViewColumnSettingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ViewColumnSettingToolStripMenuItem.Text = "表示カラム設定(&C)";
            this.ViewColumnSettingToolStripMenuItem.Click += new System.EventHandler(this.ViewColumnSettingToolStripMenuItem_Click);
            // 
            // AnalyzingPatternSettingToolStripMenuItem
            // 
            this.AnalyzingPatternSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AnalyzingPatternSettingToolStripMenuItem.Image")));
            this.AnalyzingPatternSettingToolStripMenuItem.Name = "AnalyzingPatternSettingToolStripMenuItem";
            this.AnalyzingPatternSettingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.AnalyzingPatternSettingToolStripMenuItem.Text = "解析パターン設定(&P)";
            this.AnalyzingPatternSettingToolStripMenuItem.Click += new System.EventHandler(this.AnalyzingSettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // AppSettingToolStripMenuItem
            // 
            this.AppSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AppSettingToolStripMenuItem.Image")));
            this.AppSettingToolStripMenuItem.Name = "AppSettingToolStripMenuItem";
            this.AppSettingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.AppSettingToolStripMenuItem.Text = "アプリケーション設定(&A)";
            this.AppSettingToolStripMenuItem.Click += new System.EventHandler(this.AppSettingToolStripMenuItem_Click);
            // 
            // 拡張機能設定XToolStripMenuItem
            // 
            this.拡張機能設定XToolStripMenuItem.Enabled = false;
            this.拡張機能設定XToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("拡張機能設定XToolStripMenuItem.Image")));
            this.拡張機能設定XToolStripMenuItem.Name = "拡張機能設定XToolStripMenuItem";
            this.拡張機能設定XToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.拡張機能設定XToolStripMenuItem.Text = "拡張機能設定(&X)";
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
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.MoveToolStripMenuItem.Text = "移動(&M)";
            // 
            // PreviousResultToolStripMenuItem
            // 
            this.PreviousResultToolStripMenuItem.Name = "PreviousResultToolStripMenuItem";
            this.PreviousResultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.PreviousResultToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.PreviousResultToolStripMenuItem.Text = "前ページへ移動";
            this.PreviousResultToolStripMenuItem.Click += new System.EventHandler(this.PreviousResultToolStripMenuItem_Click);
            // 
            // NextResultToolStripMenuItem
            // 
            this.NextResultToolStripMenuItem.Name = "NextResultToolStripMenuItem";
            this.NextResultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.NextResultToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.NextResultToolStripMenuItem.Text = "次ページへ移動";
            this.NextResultToolStripMenuItem.Click += new System.EventHandler(this.NextResultToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // MoveFirstRowToolStripMenuItem
            // 
            this.MoveFirstRowToolStripMenuItem.Name = "MoveFirstRowToolStripMenuItem";
            this.MoveFirstRowToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.MoveFirstRowToolStripMenuItem.Text = "先頭行へ移動";
            this.MoveFirstRowToolStripMenuItem.Click += new System.EventHandler(this.MoveFirstRowToolStripMenuItem_Click);
            // 
            // MoveLastRowToolStripMenuItem
            // 
            this.MoveLastRowToolStripMenuItem.Name = "MoveLastRowToolStripMenuItem";
            this.MoveLastRowToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.MoveLastRowToolStripMenuItem.Text = "最終行へ移動";
            this.MoveLastRowToolStripMenuItem.Click += new System.EventHandler(this.MoveLastRowToolStripMenuItem_Click);
            // 
            // MoveLineNumberToolStripMenuItem
            // 
            this.MoveLineNumberToolStripMenuItem.Name = "MoveLineNumberToolStripMenuItem";
            this.MoveLineNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.MoveLineNumberToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.MoveLineNumberToolStripMenuItem.Text = "行番号指定で移動";
            this.MoveLineNumberToolStripMenuItem.Click += new System.EventHandler(this.MoveLineNumberToolStripMenuItem_Click);
            // 
            // HighlightToolStripMenuItem
            // 
            this.HighlightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HighlightSettingToolStripMenuItem,
            this.JumpPreviousToolStripMenuItem,
            this.JumpNextToolStripMenuItem});
            this.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem";
            this.HighlightToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.HighlightToolStripMenuItem.Text = "検索(&S)";
            // 
            // HighlightSettingToolStripMenuItem
            // 
            this.HighlightSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HighlightSettingToolStripMenuItem.Image")));
            this.HighlightSettingToolStripMenuItem.Name = "HighlightSettingToolStripMenuItem";
            this.HighlightSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.HighlightSettingToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.HighlightSettingToolStripMenuItem.Text = "ハイライト設定";
            this.HighlightSettingToolStripMenuItem.Click += new System.EventHandler(this.HighlightSettingToolStripMenuItem_Click);
            // 
            // JumpPreviousToolStripMenuItem
            // 
            this.JumpPreviousToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("JumpPreviousToolStripMenuItem.Image")));
            this.JumpPreviousToolStripMenuItem.Name = "JumpPreviousToolStripMenuItem";
            this.JumpPreviousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.JumpPreviousToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.JumpPreviousToolStripMenuItem.Text = "前へ移動";
            this.JumpPreviousToolStripMenuItem.Click += new System.EventHandler(this.JumpPreviousToolStripMenuItem_Click);
            // 
            // JumpNextToolStripMenuItem
            // 
            this.JumpNextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("JumpNextToolStripMenuItem.Image")));
            this.JumpNextToolStripMenuItem.Name = "JumpNextToolStripMenuItem";
            this.JumpNextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.JumpNextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.JumpNextToolStripMenuItem.Text = "次へ移動";
            this.JumpNextToolStripMenuItem.Click += new System.EventHandler(this.JumpNextToolStripMenuItem_Click);
            // 
            // FilteringToolStripMenuItem
            // 
            this.FilteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilteringRangeSettingToolStripMenuItem,
            this.FilteringColumnSettingToolStripMenuItem});
            this.FilteringToolStripMenuItem.Name = "FilteringToolStripMenuItem";
            this.FilteringToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.FilteringToolStripMenuItem.Text = "フィルタリング(&I)";
            // 
            // FilteringRangeSettingToolStripMenuItem
            // 
            this.FilteringRangeSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilteringRangeSettingToolStripMenuItem.Image")));
            this.FilteringRangeSettingToolStripMenuItem.Name = "FilteringRangeSettingToolStripMenuItem";
            this.FilteringRangeSettingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.FilteringRangeSettingToolStripMenuItem.Text = "範囲指定(&R)";
            this.FilteringRangeSettingToolStripMenuItem.Click += new System.EventHandler(this.FilteringRangeSettingToolStripMenuItem_Click);
            // 
            // FilteringColumnSettingToolStripMenuItem
            // 
            this.FilteringColumnSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilteringColumnSettingToolStripMenuItem.Image")));
            this.FilteringColumnSettingToolStripMenuItem.Name = "FilteringColumnSettingToolStripMenuItem";
            this.FilteringColumnSettingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.FilteringColumnSettingToolStripMenuItem.Text = "カラム指定(&C)";
            this.FilteringColumnSettingToolStripMenuItem.Click += new System.EventHandler(this.FilteringColumnSettingToolStripMenuItem_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.Enabled = false;
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(74, 22);
            this.ToolsMenu.Text = "ツール(&T)";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(75, 22);
            this.helpMenu.Text = "ヘルプ(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripMenuItem.Image")));
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.AboutToolStripMenuItem.Text = "バージョン情報(&A)";
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
            this.statusStrip.Location = new System.Drawing.Point(0, 603);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1010, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // ExecutionProgressToolStrip
            // 
            this.ExecutionProgressToolStrip.Name = "ExecutionProgressToolStrip";
            this.ExecutionProgressToolStrip.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 18);
            this.toolStripStatusLabel2.Text = "状態:";
            // 
            // StatusMessageStripStatusLabel
            // 
            this.StatusMessageStripStatusLabel.Name = "StatusMessageStripStatusLabel";
            this.StatusMessageStripStatusLabel.Size = new System.Drawing.Size(636, 18);
            this.StatusMessageStripStatusLabel.Spring = true;
            this.StatusMessageStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(49, 18);
            this.toolStripStatusLabel5.Text = "総行数:";
            // 
            // TotalLineCountToolStripStatusLabel
            // 
            this.TotalLineCountToolStripStatusLabel.Name = "TotalLineCountToolStripStatusLabel";
            this.TotalLineCountToolStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(73, 18);
            this.toolStripStatusLabel3.Text = "検索結果数:";
            // 
            // TargetLineCountToolStripStatusLabel
            // 
            this.TargetLineCountToolStripStatusLabel.Name = "TargetLineCountToolStripStatusLabel";
            this.TargetLineCountToolStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(49, 18);
            this.toolStripStatusLabel4.Text = "表示数:";
            // 
            // DisplayedRowNumStripStatusLabel
            // 
            this.DisplayedRowNumStripStatusLabel.Name = "DisplayedRowNumStripStatusLabel";
            this.DisplayedRowNumStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 18);
            this.toolStripStatusLabel1.Text = "開始行:";
            // 
            // StartIndexStripStatusLabel
            // 
            this.StartIndexStripStatusLabel.Name = "StartIndexStripStatusLabel";
            this.StartIndexStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.AllowUserToDeleteRows = false;
            this.LogDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNumColumn,
            this.MessageColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.LogDataGridView.Location = new System.Drawing.Point(0, 26);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.RowHeadersVisible = false;
            this.LogDataGridView.RowTemplate.Height = 21;
            this.LogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDataGridView.Size = new System.Drawing.Size(1010, 577);
            this.LogDataGridView.TabIndex = 1;
            this.LogDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.LogDataGridView_CellPainting);
            this.LogDataGridView.Resize += new System.EventHandler(this.LogDataGridView_Resize);
            // 
            // LineNumColumn
            // 
            this.LineNumColumn.HeaderText = "行";
            this.LineNumColumn.Name = "LineNumColumn";
            this.LineNumColumn.ReadOnly = true;
            this.LineNumColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.LineNumColumn.Width = 30;
            // 
            // MessageColumn
            // 
            this.MessageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MessageColumn.HeaderText = "メッセージ";
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
            this.OpenProjectFileDialog.Filter = "\"プロジェクト ファイル (*.flat)|*.flat|すべてのファイル (*.*)|*.*\"";
            // 
            // SaveProjectFileDialog
            // 
            this.SaveProjectFileDialog.Filter = "プロジェクト ファイル (*.flat)|*.flat|すべてのファイル (*.*)|*.*";
            // 
            // SaveExportedLogFileDialog
            // 
            this.SaveExportedLogFileDialog.Filter = "CSVファイル|*.csv|Excelファイル|*.xlsx";
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
            // RegistExtensionToolStripMenuItem
            // 
            this.RegistExtensionToolStripMenuItem.Name = "RegistExtensionToolStripMenuItem";
            this.RegistExtensionToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.RegistExtensionToolStripMenuItem.Text = "拡張子をWindowsへ登録(&R)";
            this.RegistExtensionToolStripMenuItem.Click += new System.EventHandler(this.RegistExtensionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 626);
            this.Controls.Add(this.LogDataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "FLAT (Flexible Log Analyzing Tool)";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
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
    }
}



