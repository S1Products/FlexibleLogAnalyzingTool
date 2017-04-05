using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Configuration;

using System.Drawing.Printing;
using FlatEngine;
using FlatEngine.Export;
using FlatEngine.IntermediateLog;

namespace FlexibleLogAnalyzerTool
{
    public partial class MainForm : Form
    {
        private Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        public const int FILE_NAME_INDEX = 0;
        public const int LINE_NUM_INDEX = FILE_NAME_INDEX + 1;
        public const int HAS_ERROR_INDEX = LINE_NUM_INDEX + 1;
        public const int NOT_PARSED_INDEX = HAS_ERROR_INDEX + 1;
        
        public const int FIRST_CONTENT_INDEX = NOT_PARSED_INDEX + 1;

        public const string LINE_NUMBER_HEADER_NAME = "行";
        public const string FILE_NAME_HEADER_NAME = "ファイル名";
        public const string HAS_ERROR_HEADER_NAME = "___HasError";
        public const string NOT_PARSED_LINE_HEADER_NAME = "___NotParsedLine";
        public const string HIGHLIGHT_HEADER_NAME = "___Highlight";

        public const int BORDER_SIZE = 1;

        public const int PRINT_SIDE_MARGIN = 30;
        public const int PRINT_HEAD_MARGIN = 70;

        public const int PRINT_HEADER_START_X = 30;

        private ProjectAccessor projAccessor = new ProjectAccessor();
        private string currentProjectFilePath = null;
        private FlatProject currentProject;

        private int currentOffset;

        private int printingCount;
        private int printingPosition;
        private string printContents;
        private Font printFont = new Font("ＭＳ ゴシック", 8);

        public MainForm()
        {
            log.In();

            InitializeComponent();
            SettingFileAccessor.InitializeSettingDirectories(Application.StartupPath);
            InvalidateMenuItems();
            log.Out();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.InPrivate();

            CloseCurrentProject();

            log.Out();
        }

        public void OpenProject(string projectFile)
        {
            try
            {
                log.In();

                CloseCurrentProject();

                currentOffset = 0;

                currentProjectFilePath = projectFile;

                currentProject = projAccessor.OpenProject(currentProjectFilePath);

                OpenCurrentProject();

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("プロジェクトが開けませんでした。", ex);
            }

        }

        #region "メニュー"

        #region "ファイル"

        private async void AddNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                NewProjectSettingDialog dialog = new NewProjectSettingDialog();
                if (dialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                {
                    log.Out();
                    return;
                }

                if (dialog.LogFileName == "")
                {
                    ShowWarningMessage("ログファイル名が指定されていません。");
                    log.Out();
                    return;
                }

                InvalidateAllMenuItems();

                CloseCurrentProject();

                string projectName = dialog.ProjectName;
                string targetFileOrFolder = dialog.LogFileName;
                PatternDefinition pattern = dialog.SelectedPattern;

                TotalLineCountToolStripStatusLabel.Text = "";

                List<string> logFileList = new List<string>();

                if (dialog.IsFile)
                {
                    logFileList.Add(targetFileOrFolder);
                }
                else
                {
                    string filePattern = dialog.FilePattern;
                    string[] fileList = Directory.GetFiles(targetFileOrFolder, filePattern);
                    logFileList.AddRange(fileList);
                }

                DateTime startTime = DateTime.Now;

                for (int i = 0; i < logFileList.Count; i++ )
                {
                    string logFileName = logFileList[i];

                    StartExecutionProgress("ログを解析中です... ファイル名:" + logFileName);

                    if (i == 0)
                    {
                        await Task.Run(() => currentProject
                            = projAccessor.CreateProject(logFileName, projectName, pattern, dialog.FileEncoding));

                    }
                    else
                    {
                        await Task.Run(() => projAccessor.ImportLog(logFileName, dialog.FileEncoding));
                    }
                }

                long elapsed = (DateTime.Now.Ticks - startTime.Ticks) / 10000000;

                StopExecutionProgress("ログの解析が完了しました。(解析にかかった時間: " + elapsed.ToString() + "秒)");

                if (!dialog.IsFile)
                {
                    currentProject.ShowFileName = true;
                }

                currentOffset = 0;
                OpenCurrentProject();

                log.Out();

            }
            catch (Exception ex)
            {
                ShowErrorMessage("新規プロジェクトの作成に失敗しました。", ex);
            }
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (OpenProjectFileDialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                {
                    log.Out();
                    return;
                }

                OpenProject(OpenProjectFileDialog.FileName);

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("プロジェクトが開けませんでした。", ex);
            }
        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (currentProjectFilePath == null)
                {
                    SaveAsProjectToolStripMenuItem_Click(sender, e);
                }

                projAccessor.SaveProject(currentProjectFilePath);
                ShowNormalMessage("プロジェクトを保存しました。");

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("プロジェクトを保存できませんでした。", ex);
            }
        }

        private void SaveAsProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (SaveProjectFileDialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                {
                    log.Out();
                    return;
                }

                currentProjectFilePath = SaveProjectFileDialog.FileName;
                projAccessor.SaveProject(currentProjectFilePath);
                ShowNormalMessage("プロジェクトを保存しました。");

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("プロジェクトを保存できませんでした。", ex);
            }
        }

        private async void ImportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                ImportLogFileDialog dialog = new ImportLogFileDialog();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    currentProject.ShowFileName = true;

                    string targetFileOrFolder = dialog.LogFileName;

                    List<string> logFileList = new List<string>();

                    if (dialog.IsFile)
                    {
                        logFileList.Add(targetFileOrFolder);
                    }
                    else
                    {
                        string filePattern = dialog.FilePattern;
                        string[] fileList = Directory.GetFiles(targetFileOrFolder, filePattern);
                        logFileList.AddRange(fileList);
                    }

                    DateTime startTime = DateTime.Now;

                    for (int i = 0; i < logFileList.Count; i++)
                    {
                        string logFileName = logFileList[i];

                        StartExecutionProgress("ログを解析中です... ファイル名:" + logFileName);

                        await Task.Run(() => projAccessor.ImportLog(logFileName, dialog.FileEncoding));
                    }

                    long elapsed = (DateTime.Now.Ticks - startTime.Ticks) / 10000000;

                    StopExecutionProgress("ログの解析が完了しました。(解析にかかった時間: " + elapsed.ToString() + "秒)");

                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ログをエクスポートできませんでした。", ex);
            }
        }

        private void ExportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (SaveExportedLogFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    LogExporter exporter = null;

                    // フィルタインデックス「1」はCSVをあらわす
                    if (SaveExportedLogFileDialog.FilterIndex == 1)
                    {
                        exporter = new CSVLogExporter(SaveExportedLogFileDialog.FileName);
                    }
                    else
                    {
                        exporter = new ExcelLogExporter(SaveExportedLogFileDialog.FileName);
                    }

                    using (exporter)
                    {
                        projAccessor.ExportLog(exporter);
                    }
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ログをエクスポートできませんでした。", ex);
            }
        }

        private void PrintLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                printContents = "";
                printingCount = 0;
                printingPosition = 0;

                PrintDocument printDoc = new PrintDocument();
                printDoc.DefaultPageSettings.Margins
                    = new Margins(PRINT_SIDE_MARGIN, PRINT_SIDE_MARGIN, PRINT_HEAD_MARGIN, PRINT_HEAD_MARGIN);

                printDoc.PrintPage +=
                    new System.Drawing.Printing.PrintPageEventHandler(PrintDocument_PrintPage);

                PrintLogDialog.Document = printDoc;

                if (PrintLogDialog.ShowDialog() == DialogResult.OK)
                {
                    if (PrintLogDialog.PrinterSettings.PrintRange == PrintRange.Selection)
                    {
                        printContents = GetSelectionLogDataValues();
                    }
                    else
                    {
                        printContents = GetAllLogDataValues();
                    }

                    printDoc.Print();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ログを印刷できませんでした。", ex);
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                this.Close();

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("アプリを終了できませんでした。", ex);
            }
        }

        #endregion

        #region "設定"

        private void ViewColumnSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                log.In();

                ViewColumnSettingDialog dialog = new ViewColumnSettingDialog(currentProject);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    currentProject.PatternDefinition.ColumnDefinitionList = dialog.ColumnDefinitionList;
                    currentProject.ShowFileName = dialog.ShowFileName;
                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("カラム設定表示中にエラーが発生しました。", ex);
            }
        }

        private void AnalyzingSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                PatternSettingDialog dialog = new PatternSettingDialog();
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    //TODO
                }

                log.Out();

            }
            catch (Exception ex)
            {
                ShowErrorMessage("解析パターン設定表示中にエラーが発生しました。", ex);
            }
        }

        private void AppSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                AppSettingDialog dialog = new AppSettingDialog();
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("アプリケーション設定表示中にエラーが発生しました。", ex);
            }
        }

        #endregion

        #region "移動"

        private void MoveFirstRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                MoveToFirstRow();

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("先頭行へ移動中にエラーが発生しました。", ex);
            }
        }

        private void MoveLastRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                MoveToLastRow();

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("最終行へ移動中にエラーが発生しました。", ex);
            }
        }

        private void MoveLineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                MoveToSpecifiedRow();

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("指定行へ移動中にエラーが発生しました。", ex);
            }
        }

        #endregion

        #region "検索"

        private void HighlightSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                HighlightSettingDialog dialog = new HighlightSettingDialog(currentProject);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    currentProject.HighlightDefinitionList = dialog.HighlightDefinitionList;
                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ハイライト設定表示中にエラーが発生しました。", ex);
            }
        }

        private void JumpPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (LogDataGridView.SelectedRows.Count == 0)
                {
                    log.Out();
                    return;
                }

                int index = LogDataGridView.SelectedRows[0].Index;

                for (int i = index - 1; i >= 0; i--)
                {
                    DataGridViewRow viewRow = LogDataGridView.Rows[i];
                    DataRow row = (DataRow)((DataRowView)viewRow.DataBoundItem).Row;

                    if (HasJumpTarget(row))
                    {
                        MoveRow(i);
                        log.Out();
                        return;
                    }
                }

                ShowWarningMessage("ジャンプ可能な行が見つかりませんでした");

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ハイライトへのジャンプ中にエラーが発生しました。", ex);
            }
        }

        private void JumpNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                if (LogDataGridView.SelectedRows.Count == 0)
                {
                    log.Out();
                    return;
                }

                int index = LogDataGridView.SelectedRows[0].Index;
                for (int i = index + 1; i < LogDataGridView.Rows.Count; i++)
                {
                    DataGridViewRow viewRow = LogDataGridView.Rows[i];
                    DataRow row = (DataRow)((DataRowView)viewRow.DataBoundItem).Row;

                    if (HasJumpTarget(row))
                    {
                        MoveRow(i);
                        log.Out();
                        return;
                    }
                }

                ShowWarningMessage("ジャンプ可能な行が見つかりませんでした");

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ハイライトへのジャンプ中にエラーが発生しました。", ex);
            }
        }

        private bool HasJumpTarget(DataRow row)
        {
            foreach (object val in row.ItemArray)
            {
                if (val == null || val.GetType() != typeof(HighlightList))
                {
                    continue;
                }

                HighlightList highlightList = (HighlightList)val;

                foreach (Highlight highlight in highlightList)
                {
                    if (highlight.HighlightDefinition.Jumpable)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion

        #region "フィルタリング"

        private void FilteringRangeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                List<FileValue> fileList = projAccessor.GetLogReader().GetAllFileValueList();

                FilteringRangeSettingDialog dialog = new FilteringRangeSettingDialog(currentProject, fileList);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    currentProject.RangeCriteria = dialog.RangeCriteria;
                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("範囲設定表示中にエラーが発生しました。", ex);
            }
        }

        private void FilteringColumnSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                FilteringColumnSettingDialog dialog
                    = new FilteringColumnSettingDialog(currentProject);
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    currentProject.ColumnsSearchCriteria = dialog.SearchCriteria;
                    OpenCurrentProject();
                }

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("カラム指定表示中にエラーが発生しました。", ex);
            }
        }

        #endregion

        #region "ヘルプ"

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.In();

                FLATAboutBox dialog = new FLATAboutBox();
                dialog.ShowDialog(this);

                log.Out();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ヘルプ表示中にエラーが発生しました。", ex);
            }
        }

        #endregion

        #endregion

        #region "描画処理"

        #region "エラー行の描画処理"

        private void LogDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                log.InPrivate();

                // 行が1件もない、ヘッダー行を指している、行番号カラムを指している場合
                if (LogDataGridView.Rows.Count == 0 || e.RowIndex < 0)
                {
                    log.OutPrivate();
                    return;
                }

                DataTable table = (DataTable)LogDataGridView.DataSource;
                DataRow row = table.Rows[e.RowIndex];

                if ((bool)row[HAS_ERROR_HEADER_NAME])
                {
                    PaintCellNotParsedRow(row, e);
                }
                else
                {
                    PaintCellParsedRow(row, e);
                }

                log.OutPrivate();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("ログのグリッド表示中にエラーが発生しました。", ex);
            }
        }

        private void PaintCellNotParsedRow(DataRow row, DataGridViewCellPaintingEventArgs e)
        {
            log.InPrivate(row, e);

            e.Handled = false;

            DataGridViewRow viewRow = LogDataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex != viewRow.Cells.Count - 1)   //最終カラム
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }

            e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;

            if (e.ColumnIndex == LINE_NUM_INDEX 
                || (e.ColumnIndex == FILE_NAME_INDEX && currentProject.ShowFileName))
            {
                e.AdvancedBorderStyle.Right = LogDataGridView.AdvancedCellBorderStyle.Right;
                e.AdvancedBorderStyle.Left = LogDataGridView.AdvancedCellBorderStyle.Left;
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);
            }
            else if (e.ColumnIndex == FIRST_CONTENT_INDEX)
            {
                DrawNotParsedLine(row, e);
            }

            e.Handled = true;

            log.OutPrivate();
        }

        private void DrawNotParsedLine(DataRow row, DataGridViewCellPaintingEventArgs e)
        {
            log.InPrivate(row, e);

            Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, 0, e.CellBounds.Height);

            // 行番号カラムとエラー行を無視してWidthを計算
            for (int i = FIRST_CONTENT_INDEX; i < LogDataGridView.Columns.Count; i++)
            {
                DataGridViewColumn col = LogDataGridView.Columns[i];
                rect.Width += col.Width;
            }

            // グリッドの線分縮める
            rect.Width -= BORDER_SIZE;
            //rect.Height -= BORDER_SIZE;   // 下側の区切り線を描画させないため、あえてコメントアウト

            // 背景色の処理
            Brush backcolorBrush = null;
            Brush forecolorBrush = null;

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                backcolorBrush = new SolidBrush(LogDataGridView.DefaultCellStyle.SelectionBackColor);
                forecolorBrush = new SolidBrush(LogDataGridView.DefaultCellStyle.SelectionForeColor);
            }
            else
            {
                backcolorBrush = new SolidBrush(LogDataGridView.DefaultCellStyle.BackColor);
                forecolorBrush = new SolidBrush(LogDataGridView.DefaultCellStyle.ForeColor);
            }

            e.Graphics.FillRectangle(backcolorBrush, rect);
            e.Graphics.DrawString(row[NOT_PARSED_LINE_HEADER_NAME].ToString(), LogDataGridView.Font, forecolorBrush, e.CellBounds.X + BORDER_SIZE, e.CellBounds.Y + BORDER_SIZE);

            log.OutPrivate();
        }

        private void PaintCellParsedRow(DataRow row, DataGridViewCellPaintingEventArgs e)
        {
            log.InPrivate(row, e);

            DataGridViewRow viewRow = LogDataGridView.Rows[e.RowIndex];
            DataGridViewCell cell = viewRow.Cells[e.ColumnIndex];

            string propName = cell.OwningColumn.DataPropertyName;

            if (propName == FILE_NAME_HEADER_NAME || propName == LINE_NUMBER_HEADER_NAME)
            {
                return;
            }

            object obj = row[cell.OwningColumn.DataPropertyName + HIGHLIGHT_HEADER_NAME];

            if (obj != DBNull.Value && obj.GetType() == typeof(HighlightList))
            {
                HighlightList highlightList = (HighlightList)obj;

                if (highlightList.Count > 0)
                {
                    Color col = highlightList[0].HighlightDefinition.HighlightColor;

                    cell.Style.BackColor = col;
                    cell.Style.SelectionBackColor = col;
                }
            }

            log.OutPrivate();
        }

        private void LogDataGridView_Resize(object sender, EventArgs e)
        {
            log.In();

            LogDataGridView.Update();

            log.Out();
        }

        #endregion

        #endregion

        #region "キー入力"

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            log.In(msg, keyData);

            Keys code = keyData & Keys.KeyCode;
            Keys modi = keyData & Keys.Modifiers;
            if (modi == Keys.Control)
            {
                switch (code)
                {
                    case Keys.Home:

                        if (LogDataGridView.Rows.Count > 0)
                            ShowNormalMessage("先頭行に移動しました");
                        break;

                    case Keys.End:

                        if (LogDataGridView.Rows.Count > 0)
                            ShowNormalMessage("最終行に移動しました");
                        break;

                    case Keys.C:
                        CopyLogDataToClipboard();
                        break;

                }
            }

            bool ret = base.ProcessCmdKey(ref msg, keyData);
            log.Out(ret);
            return ret;
        }

        #endregion

        #region "内部処理"

        private void CloseCurrentProject()
        {
            log.InPrivate();

            projAccessor.CloseProject();
            currentProjectFilePath = null;

            log.OutPrivate();
        }

        private void OpenCurrentProject()
        {
            log.InPrivate();

            if (currentProject == null)
            {
                return;
            }

            this.Text = "FLAT (プロジェクト名: " + currentProject.ProjectName + ")";

            ShowLog(currentOffset);

            log.OutPrivate();
        }

        #region "ログの表示処理"

        private void ShowLog(int offset)
        {
            log.InPrivate(offset);

            IntermediateLogReader reader = projAccessor.GetLogReader();

            string dateTimeFormat = Properties.Settings.Default.DateTimeFormat;

            FlatProject proj = projAccessor.CurrentProject;

            DataTable table = new DataTable(proj.ProjectName);

            AddLogListHeader(table, proj.PatternDefinition.ColumnDefinitionList);

            int maxLineCount = Properties.Settings.Default.MaxLineCount;
            ParsedLog parsedLog = reader.ReadLines(currentProject.SearchCriteria, 
                                                   proj.PatternDefinition.ColumnDefinitionList, 
                                                   proj.HighlightDefinitionList, 
                                                   offset, maxLineCount);

            foreach (ParsedLogLine line in parsedLog.LogLineList)
            {
                DataRow row = table.NewRow();
                row[HAS_ERROR_HEADER_NAME] = line.HasError;
                row[FILE_NAME_HEADER_NAME] = line.File.Name;
                row[LINE_NUMBER_HEADER_NAME] = line.LineNumber;

                if(line.HasError){
                    row[NOT_PARSED_LINE_HEADER_NAME] = line.NotParsedLog;
                }
                else
                {
                    SetColumns(line, row, dateTimeFormat);
                }

                table.Rows.Add(row);
            }

            LogDataGridView.DataSource = table;

            ValidateMenuItems();


            TotalLineCountToolStripStatusLabel.Text = String.Format("{0:#,0}", parsedLog.TotalLineCount);
            TargetLineCountToolStripStatusLabel.Text = String.Format("{0:#,0}", parsedLog.TargetLineCount);

            string offsetStr = String.Format("{0:#,0}", currentOffset + 1);
            string rowCountStr = String.Format("{0:#,0}", LogDataGridView.Rows.Count);

            ShowNormalMessage("ログを表示しました。");
            StartIndexStripStatusLabel.Text = offsetStr;
            DisplayedRowNumStripStatusLabel.Text = rowCountStr;
        }

        private void AddLogListHeader(DataTable table, ColumnDefinitionList colDefList)
        {
            log.InPrivate(table, colDefList);

            LogDataGridView.DataSource = null;
            LogDataGridView.Columns.Clear();

            LogDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            LogDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            AddFileNameColumn(table);

            AddLineNumberColumn(table);

            AddLineErrorColumns(table);

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (colDef.Visble == false)
                {
                    continue;
                }

                //ハイライト設定用のカラムを追加（非表示）
                DataGridViewColumn highlightCol = CreateInvisibleColumnHeader(colDef.ColumnName + HIGHLIGHT_HEADER_NAME);
                LogDataGridView.Columns.Add(highlightCol);
                table.Columns.Add(colDef.ColumnName + HIGHLIGHT_HEADER_NAME, typeof(HighlightList));

                //ログ表示用のカラムを追加
                DataGridViewColumn col = CreateDefaultColumnHeader(colDef.ColumnName);

                if (colDef.IsDateTimeField)
                {
                    col.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    col.ValueType = typeof(DateTime);
                }

                if (colDef.Resizable)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                LogDataGridView.Columns.Add(col);
                table.Columns.Add(colDef.ColumnName);
            }

            // 最終列のみ表示モードをFillに設定
            LogDataGridView.Columns[LogDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            log.OutPrivate();
        }

        private DataGridViewColumn CreateDefaultColumnHeader(string name)
        {
            log.InPrivate(name);

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = name;
            col.HeaderText = name;
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            col.Resizable = DataGridViewTriState.True;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Frozen = false;

            log.OutPrivate(col);
            return col;
        }

        private DataGridViewColumn CreateInvisibleColumnHeader(string name)
        {
            log.InPrivate(name);

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = name;
            col.HeaderText = name;
            col.Visible = false;

            log.OutPrivate(col);
            return col;
        }

        private void AddLineErrorColumns(DataTable table)
        {
            log.InPrivate(table);

            table.Columns.Add(HAS_ERROR_HEADER_NAME, typeof(bool));
            table.Columns.Add(NOT_PARSED_LINE_HEADER_NAME);

            LogDataGridView.Columns.Add(CreateInvisibleColumnHeader(HAS_ERROR_HEADER_NAME));
            LogDataGridView.Columns.Add(CreateInvisibleColumnHeader(NOT_PARSED_LINE_HEADER_NAME));

            log.OutPrivate();
        }

        private void AddLineNumberColumn(DataTable table)
        {
            log.InPrivate(table);

            DataGridViewColumn viewCol = CreateDefaultColumnHeader(LINE_NUMBER_HEADER_NAME);
            viewCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            viewCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            viewCol.DefaultCellStyle.BackColor = Color.Gray;
            viewCol.DefaultCellStyle.ForeColor = Color.AliceBlue;
            viewCol.DefaultCellStyle.SelectionBackColor = Color.Gray;
            viewCol.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            viewCol.Width = 40;
            LogDataGridView.Columns.Add(viewCol);

            table.Columns.Add(LINE_NUMBER_HEADER_NAME, typeof(int));

            log.OutPrivate();
        }

        private void AddFileNameColumn(DataTable table)
        {
            log.InPrivate(table);

            DataGridViewColumn viewCol = CreateDefaultColumnHeader(FILE_NAME_HEADER_NAME);
            viewCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            viewCol.DefaultCellStyle.BackColor = Color.Gray;
            viewCol.DefaultCellStyle.ForeColor = Color.AliceBlue;
            viewCol.DefaultCellStyle.SelectionBackColor = Color.Gray;
            viewCol.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            if (currentProject.ShowFileName == false)
            {
                viewCol.Visible = false;
            }

            LogDataGridView.Columns.Add(viewCol);

            table.Columns.Add(FILE_NAME_HEADER_NAME, typeof(string));

            log.OutPrivate();
        }

        private void SetColumns(ParsedLogLine line, DataRow row, string dateTimeFormat)
        {
            log.InPrivate(line, row, dateTimeFormat);

            for (int i = 0; i < line.ColumnList.Count; i++)
            {
                ParsedLogColumn col = line.ColumnList[i];

                string colName = col.ColumnDefinition.ColumnName;
                string value = null;

                if (col.ColumnDefinition.Visble == false) 
                {
                    continue;
                }
                else if (col.ColumnDefinition.IsDateTimeField)
                {
                    DateTime time = new DateTime(long.Parse(col.Value));
                    value = time.ToString(dateTimeFormat);
                }
                else
                {
                    value = col.Value;
                }

                row[colName] = value;
                row[colName + HIGHLIGHT_HEADER_NAME] = col.HighlightList;
            }

            log.OutPrivate();
        }

        #endregion

        #region "移動処理"

        private void PreviousResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.In();

            int maxCount = Properties.Settings.Default.MaxLineCount;

            if (currentOffset < maxCount)
            {
                currentOffset = 0;
            }
            else
            {
                currentOffset -= maxCount;
            }

            OpenCurrentProject();

            log.Out();
        }

        private void NextResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.In();

            int maxCount = Properties.Settings.Default.MaxLineCount;
            currentOffset += maxCount;

            OpenCurrentProject();

            log.Out();
        }

        private void MoveToFirstRow()
        {
            log.InPrivate();

            if (LogDataGridView.Rows.Count <= 0)
            {
                ShowWarningMessage("ログが存在しない状態では無効です");
                log.OutPrivate();
                return;
            }

            MoveRow(0);
            ShowNormalMessage("先頭行に移動しました");

            log.OutPrivate();
        }

        private void MoveToLastRow()
        {
            log.InPrivate();

            if (LogDataGridView.Rows.Count <= 0)
            {
                ShowWarningMessage("ログが存在しない状態では無効です");
                log.OutPrivate();
                return;
            }

            MoveRow(LogDataGridView.Rows.Count - 1);
            ShowNormalMessage("最終行に移動しました");

            log.OutPrivate();
        }

        private void MoveToSpecifiedRow()
        {
            log.InPrivate();

            if (LogDataGridView.Rows.Count <= 0)
            {
                ShowWarningMessage("ログが存在しない状態では無効です");
                log.OutPrivate();
                return;
            }

            string lineNumStr = Interaction.InputBox("行番号を入力");

            if (lineNumStr == "")
            {
                log.OutPrivate();
                return;
            }

            int lineNum = int.Parse(lineNumStr);

            int foundLineNum = -1;
            int rowIndex = FindNearRowIndexByLineNumber(lineNum, ref foundLineNum);

            if (rowIndex == -1)
            {
                ShowWarningMessage("指定行が見つかりませんでした");
                log.OutPrivate();
                return;
            }

            MoveRow(rowIndex);

            log.OutPrivate();
        }

        private void MoveRow(int rowIndex)
        {
            log.InPrivate(rowIndex);

            int dispRows = LogDataGridView.DisplayedRowCount(true);

            int scrollIndex = rowIndex - dispRows / 2;
            if(scrollIndex < 0){
                scrollIndex = 0;
            }
            else if (scrollIndex > LogDataGridView.Rows.Count)
            {
                scrollIndex = LogDataGridView.Rows.Count;
            }

            LogDataGridView.FirstDisplayedScrollingRowIndex = scrollIndex;
            LogDataGridView.Rows[rowIndex].Selected = true;
            LogDataGridView.CurrentCell = LogDataGridView[0, rowIndex];

            ShowNormalMessage((rowIndex + 1) + "行目に移動しました");

            log.OutPrivate();
        }

        #endregion

        #region "ステータス表示"

        private void ShowNormalMessage(string message)
        {
            log.InPrivate(message);

            StatusMessageStripStatusLabel.Text = message;
            StatusMessageStripStatusLabel.ForeColor = Color.Black;

            log.Info(message);

            log.OutPrivate();
        }

        private void ShowWarningMessage(string message)
        {
            log.InPrivate(message);

            StatusMessageStripStatusLabel.Text = message;
            StatusMessageStripStatusLabel.ForeColor = Color.Red;

            log.Warn(message);

            log.OutPrivate();
        }

        private void ShowErrorMessage(string message, Exception ex)
        {
            log.InPrivate(message, ex);

            StatusMessageStripStatusLabel.Text = message + ex.Message;
            StatusMessageStripStatusLabel.ForeColor = Color.Red;

            log.Error(message, ex);

            log.OutPrivate();
        }

        private void StartExecutionProgress(string message)
        {
            log.InPrivate(message);

            ProgressTimer.Start();

            ShowNormalMessage(message);

            log.OutPrivate();
        }

        private void StopExecutionProgress(string message)
        {
            log.InPrivate(message);

            ProgressTimer.Stop();
            ExecutionProgressToolStrip.Value = 0;

            ShowNormalMessage(message);

            log.OutPrivate();
        }

        #endregion

        #region "メニュー表示"

        private void InvalidateAllMenuItems()
        {
            log.InPrivate();

            FileMenu.Enabled = false;
            SettingsMenu.Enabled = false;
            ToolsMenu.Enabled = false;
            ViewColumnSettingToolStripMenuItem.Enabled = false;
            MoveToolStripMenuItem.Enabled = false;
            HighlightToolStripMenuItem.Enabled = false;
            FilteringToolStripMenuItem.Enabled = false;

            log.OutPrivate();
        }

        private void InvalidateMenuItems()
        {
            log.InPrivate();

            ImportLogToolStripMenuItem.Enabled = false;
            ExportLogToolStripMenuItem.Enabled = false;
            PrintLogToolStripMenuItem.Enabled = false;

            SaveProjectToolStripMenuItem.Enabled = false;
            SaveAsProjectToolStripMenuItem.Enabled = false;

            ViewColumnSettingToolStripMenuItem.Enabled = false;
            MoveToolStripMenuItem.Enabled = false;
            HighlightToolStripMenuItem.Enabled = false;
            FilteringToolStripMenuItem.Enabled = false;

            log.OutPrivate();
        }

        private void ValidateMenuItems()
        {
            log.InPrivate();

            FileMenu.Enabled = true;

            ImportLogToolStripMenuItem.Enabled = true;
            ExportLogToolStripMenuItem.Enabled = true;
            PrintLogToolStripMenuItem.Enabled = true;

            SaveProjectToolStripMenuItem.Enabled = true;
            SaveAsProjectToolStripMenuItem.Enabled = true;

            SettingsMenu.Enabled = true;
            ToolsMenu.Enabled = true;
            ViewColumnSettingToolStripMenuItem.Enabled = true;
            MoveToolStripMenuItem.Enabled = true;
            HighlightToolStripMenuItem.Enabled = true;
            FilteringToolStripMenuItem.Enabled = true;

            log.OutPrivate();
        }

        #endregion

        #region "コピー処理"

        private void CopyLogDataToClipboard()
        {
            string logValues = GetSelectionLogDataValues();
            Clipboard.SetText(logValues);
        }

        private string GetAllLogDataValues()
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow viewRow in LogDataGridView.Rows)
            {
                DataRow dataRow = ((DataTable)LogDataGridView.DataSource).Rows[viewRow.Index];
                sb.Append(GetLogDataValueFromRow(viewRow, dataRow));
            }

            return sb.ToString();
        }

        private string GetSelectionLogDataValues()
        {
            List<int> selectedRowIndexes = Sort(LogDataGridView.SelectedRows);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < selectedRowIndexes.Count; i++)
            {
                DataGridViewRow viewRow = LogDataGridView.Rows[selectedRowIndexes[i]];

                DataRow dataRow = ((DataTable)LogDataGridView.DataSource).Rows[viewRow.Index];

                sb.Append(GetLogDataValueFromRow(viewRow, dataRow));
            }

            return sb.ToString();
        }

        private string GetLogDataValueFromRow(DataGridViewRow viewRow, DataRow dataRow)
        {
            StringBuilder sb = new StringBuilder();

            bool hasError = (bool)dataRow[HAS_ERROR_HEADER_NAME];
            if (hasError)
            {
                sb.Append(dataRow[LINE_NUMBER_HEADER_NAME].ToString());
                sb.Append("\t");

                if (currentProject.ShowFileName)
                {
                    sb.Append(dataRow[FILE_NAME_HEADER_NAME]);
                    sb.Append("\t");
                }

                sb.Append(dataRow[NOT_PARSED_LINE_HEADER_NAME]);
            }
            else
            {
                foreach (DataGridViewCell viewCell in viewRow.Cells)
                {
                    DataGridViewColumn col = viewCell.OwningColumn;

                    if (col.Visible == false)
                    {
                        continue;
                    }

                    if (col.DataPropertyName == HAS_ERROR_HEADER_NAME
                        || col.DataPropertyName == NOT_PARSED_LINE_HEADER_NAME
                        || col.DataPropertyName.Contains(HIGHLIGHT_HEADER_NAME))
                    {
                        continue;
                    }

                    sb.Append(dataRow[viewCell.OwningColumn.DataPropertyName].ToString());
                    sb.Append("\t");
                }
            }

            sb.Append("\r\n");

            return sb.ToString();
        }

        private List<int> Sort(DataGridViewSelectedRowCollection selectedRows)
        {
            List<int> rowIndexList = new List<int>();

            foreach (DataGridViewRow row in selectedRows)
            {
                rowIndexList.Add(row.Index);
            }

            rowIndexList.Sort();

            return rowIndexList;
        }

        #endregion

        #region "印刷処理"

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            printingCount++;

            //改行記号を'\n'に統一する
            if (printingPosition == 0)
            {
                printContents = printContents.Replace("\r\n", "\n");
                printContents = printContents.Replace("\r", "\n");
            }

            PrintHeader(e);

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            //1ページに収まらなくなるか、印刷する文字がなくなるかまでループ
            while (e.MarginBounds.Bottom > y + printFont.Height &&
                printingPosition < printContents.Length)
            {
                string line = "";
                for (; ; )
                {
                    //印刷する文字がなくなるか、
                    //改行の時はループから抜けて印刷する
                    if (printingPosition >= printContents.Length ||
                        printContents[printingPosition] == '\n')
                    {
                        printingPosition++;
                        break;
                    }

                    //一文字追加し、印刷幅を超えるか調べる
                    line += printContents[printingPosition];
                    if (e.Graphics.MeasureString(line, printFont).Width
                        > e.MarginBounds.Width)
                    {
                        line = line.Substring(0, line.Length - 1);
                        break;
                    }

                    printingPosition++;
                }

                e.Graphics.DrawString(line, printFont, Brushes.Black, x, y);

                y += (int)printFont.GetHeight(e.Graphics);
            }

            if (printingPosition >= printContents.Length)
            {
                e.HasMorePages = false;
                printingPosition = 0;
            }
            else
            {
                e.HasMorePages = true;
            }

            PrintFooter(e);
        }

        private void PrintHeader(PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = PRINT_HEADER_START_X;

            Font headerFont = new Font(printFont, FontStyle.Italic | FontStyle.Bold);
            e.Graphics.DrawString("プロジェクト名: " + currentProject.ProjectName, headerFont, Brushes.Black, x, y);
        }

        private void PrintFooter(PrintPageEventArgs e)
        {
            Font font = new Font(printFont, FontStyle.Bold);

            float width = e.Graphics.MeasureString(printingCount.ToString(), font).Width;
            float x = (e.PageBounds.Width / 2) - (e.Graphics.MeasureString(printingCount.ToString(), font).Width / 2);
            float y = e.MarginBounds.Bottom + PRINT_HEADER_START_X;

            e.Graphics.DrawString(printingCount.ToString(), font, Brushes.Black, x, y);
        }

        #endregion

        private int FindNearRowIndexByLineNumber(int lineNum, ref int foundLineNum)
        {
            log.InPrivate(lineNum, foundLineNum);

            DataTable table = (DataTable)LogDataGridView.DataSource;

            for (int i = 0; i < table.Rows.Count; i++ )
            {
                DataRow row = table.Rows[i];

                int rowLineNum = (int)row[LINE_NUMBER_HEADER_NAME];

                if (rowLineNum >= lineNum)
                {
                    foundLineNum = rowLineNum;

                    log.OutPrivate(i);
                    return i;
                }
            }

            log.OutPrivate(-1);
            return -1;
        }

        #endregion

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            log.InPrivate();

            if (ExecutionProgressToolStrip.Value == ExecutionProgressToolStrip.Maximum)
            {
                ExecutionProgressToolStrip.Value = 0;
            }
            else
            {
                ExecutionProgressToolStrip.Value += 1;
            }

            log.OutPrivate();
        }

        private void RegistExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = Application.ExecutablePath;
            psi.Verb = "runas";
            psi.Arguments = Program.ARG_REGIST;

            try
            {
                System.Diagnostics.Process.Start(psi);
                ShowNormalMessage("拡張子を登録しました。");
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                ShowErrorMessage("拡張子を登録できませんでした。", ex);
            }
        }
    }
}
