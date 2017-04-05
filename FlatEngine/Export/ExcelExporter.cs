using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace FlatEngine.Export
{
    public class ExcelLogExporter : LogExporter
    {
        #region "Constants"

        #region "Constants for common"

        public const int MARGIN_COLUMN_INDEX = 0;
        public const int MARGIN_COLUMN_WIDTH = 256;

        public const int TITLE_FONT_SIZE = 14;

        public const int BORDER_THIN = 1;

        public const int CELL_WIDTH_BASE = 256;
        public const int CELL_WIDTH_MARGIN = 256;

        public const int DEFAULT_CELL_WIDTH = CELL_WIDTH_BASE * 50;

        public const int MAX_CELL_WIDTH = CELL_WIDTH_BASE * 100;

        public const string FORMAT_STR_DATE = "yyyy/MM/dd HH:mm:ss";

        public const string FORMAT_STR_NUMBER = "#,##0";

        #endregion

        #region "Constants for summary sheet"

        public const string SM_SHEET_NAME = "Summary";
        public const int SM_COL_POS_TITLE = 0;
        public const int SM_ROW_POS_TITLE = 1;

        public const int SM_COL_POS_HEADER_START = 1;
        public const int SM_ROW_POS_HEADER_START = SM_ROW_POS_TITLE + 1;

        public const int SM_COL_POS_CONTENT_START = SM_COL_POS_HEADER_START;
        public const int SM_ROW_POS_CONTENT_START = SM_ROW_POS_HEADER_START + 1;

        #endregion

        #region "Constants for log sheet"

        public const string LG_SHEET_NAME = "Logs";
        public const int LG_COL_POS_TITLE = 0;
        public const int LG_ROW_POS_TITLE = 1;

        public const int LG_COL_POS_HEADER_START = 1;
        public const int LG_ROW_POS_HEADER_START = LG_ROW_POS_TITLE + 1;

        public const int LG_COL_POS_CONTENT_START = LG_COL_POS_HEADER_START;
        public const int LG_ROW_POS_CONTENT_START = LG_ROW_POS_HEADER_START + 1;

        public const int LG_COL_WIDTH_FILE = CELL_WIDTH_BASE * 10;
        public const int LG_COL_WIDTH_LINE_NUM = CELL_WIDTH_BASE * 5;
        public const int LG_COL_WIDTH_CONTENT = CELL_WIDTH_BASE * 30;

        public const string LG_COL_NAME_FILE = "File";
        public const string LG_COL_NAME_LINE = "Line";

        #endregion

        #endregion

        private string fileName;
        private IWorkbook workbook;
        private ISheet summarySheet; 
        private ISheet logSheet;

        private ICellStyle titleStyle;
        private ICellStyle headerStyle;
        private ICellStyle contentStringStyle;
        private ICellStyle contentStringCenterStyle;
        private ICellStyle contentDateStyle;
        private ICellStyle contentNumberStyle;

        private Dictionary<string, int> maxCellWidthDictionary;

        public ExcelLogExporter(string fileName)
        {
            this.maxCellWidthDictionary = new Dictionary<string, int>();
            this.fileName = fileName;
            this.workbook = new XSSFWorkbook();

            this.titleStyle = CreateTitleStyle();
            this.headerStyle = CreateHeaderStyle();
            this.contentStringStyle = CreateBorderedStyle();

            this.contentStringCenterStyle = CreateBorderedStyle();
            this.contentStringCenterStyle.Alignment = HorizontalAlignment.Center;

            this.contentDateStyle = CreateBorderedStyle();
            this.contentDateStyle.DataFormat = workbook.CreateDataFormat().GetFormat(FORMAT_STR_DATE);

            this.contentNumberStyle = CreateBorderedStyle();
            this.contentNumberStyle.DataFormat = workbook.CreateDataFormat().GetFormat(FORMAT_STR_NUMBER);
        }

        public override void OnClose()
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                workbook.Write(stream);
            }
        }

        #region "Rendering"

        #region "Header"

        public override void OnRenderDocumentHeader(FlatProject project, ParsedLog log)
        {
            CreateSheets();

            GenerateSummaryHeader(project, log);
            GenerateLogHeader(project);
        }

        private void CreateSheets()
        {
            summarySheet = workbook.CreateSheet(SM_SHEET_NAME);
            SetMargin(summarySheet);

            logSheet = workbook.CreateSheet(LG_SHEET_NAME);
            SetMargin(logSheet);
        }

        private void SetMargin(ISheet sheet)
        {
            sheet.CreateRow(MARGIN_COLUMN_INDEX);
            sheet.SetColumnWidth(MARGIN_COLUMN_INDEX, MARGIN_COLUMN_WIDTH);
        }

        private void GenerateSummaryHeader(FlatProject project, ParsedLog log)
        {
            // Title
            ICell titleCell = GetSummaryCell(SM_COL_POS_TITLE, SM_ROW_POS_TITLE);
            titleCell.SetCellValue("Exported summary");
            titleCell.CellStyle = titleStyle;

            
            // Header
            ICell itemHeader = GetSummaryCell(SM_COL_POS_HEADER_START, SM_ROW_POS_HEADER_START);
            itemHeader.SetCellValue("Item");
            itemHeader.CellStyle = headerStyle;

            ICell valueHeader = GetSummaryCell(SM_COL_POS_HEADER_START + 1, SM_ROW_POS_HEADER_START);
            valueHeader.SetCellValue("Value");
            valueHeader.CellStyle = headerStyle;

            // Contents
            ICell nameTitleCell = GetSummaryCell(SM_COL_POS_CONTENT_START, SM_ROW_POS_CONTENT_START);
            nameTitleCell.SetCellValue("Project name");
            nameTitleCell.CellStyle = contentStringStyle;

            ICell nameCell = GetSummaryCell(SM_COL_POS_CONTENT_START + 1, SM_ROW_POS_CONTENT_START);
            nameCell.SetCellValue(project.ProjectName);
            nameCell.CellStyle = contentStringStyle;


            ICell expDateTitleCell = GetSummaryCell(SM_COL_POS_CONTENT_START, SM_ROW_POS_CONTENT_START + 1);
            expDateTitleCell.SetCellValue("Exported date");
            expDateTitleCell.CellStyle = contentStringStyle;

            ICell expDateCell = GetSummaryCell(SM_COL_POS_CONTENT_START + 1, SM_ROW_POS_CONTENT_START + 1);
            expDateCell.SetCellValue(DateTime.Now);
            expDateCell.CellStyle = contentDateStyle;


            ICell totalCountTitleCell = GetSummaryCell(SM_COL_POS_CONTENT_START, SM_ROW_POS_CONTENT_START + 2);
            totalCountTitleCell.SetCellValue("Total count");
            totalCountTitleCell.CellStyle = contentStringStyle;

            ICell totalCountCell = GetSummaryCell(SM_COL_POS_CONTENT_START + 1, SM_ROW_POS_CONTENT_START + 2);
            totalCountCell.SetCellValue(log.TotalLineCount);
            totalCountCell.CellStyle = contentNumberStyle;


            ICell expCountTitleCell = GetSummaryCell(SM_COL_POS_CONTENT_START, SM_ROW_POS_CONTENT_START + 3);
            expCountTitleCell.SetCellValue("Exported count");
            expCountTitleCell.CellStyle = contentStringStyle;

            ICell expCountCell = GetSummaryCell(SM_COL_POS_CONTENT_START + 1, SM_ROW_POS_CONTENT_START + 3);
            expCountCell.SetCellValue(log.TargetLineCount);
            expCountCell.CellStyle = contentNumberStyle;


            // Auto resize Item and Value column
            summarySheet.SetColumnWidth(SM_COL_POS_CONTENT_START, DEFAULT_CELL_WIDTH);
            summarySheet.AutoSizeColumn(SM_COL_POS_CONTENT_START);

            summarySheet.SetColumnWidth(SM_COL_POS_CONTENT_START + 1, DEFAULT_CELL_WIDTH);
            summarySheet.AutoSizeColumn(SM_COL_POS_CONTENT_START + 1);
        }

        private void GenerateLogHeader(FlatProject project)
        {
            // Title
            ICell titleCell = GetCell(logSheet, LG_COL_POS_TITLE, LG_ROW_POS_TITLE);
            titleCell.SetCellValue("Exported logs");
            titleCell.CellStyle = titleStyle;


            // Header
            int colPos = LG_COL_POS_HEADER_START;

            if (project.ShowFileName)
            {
                ICell fileCell = GetLogHeaderCell(colPos, LG_ROW_POS_HEADER_START);
                fileCell.SetCellValue("File");
                logSheet.SetColumnWidth(colPos, LG_COL_WIDTH_FILE);
                colPos++;
            }

            ICell logLineCell = GetLogHeaderCell(colPos, LG_ROW_POS_HEADER_START);
            logLineCell.SetCellValue("Line");
            logSheet.SetColumnWidth(colPos, LG_COL_WIDTH_LINE_NUM);
            colPos++;

            foreach (ColumnDefinition colDef in project.PatternDefinition.ColumnDefinitionList)
            {
                if (colDef.Visble == false)
                {
                    continue;
                }

                ICell cell = GetLogHeaderCell(colPos, LG_ROW_POS_HEADER_START);
                cell.SetCellValue(colDef.ColumnName);
                logSheet.SetColumnWidth(colPos, LG_COL_WIDTH_CONTENT);
                colPos++;
            }
        }

        #endregion

        #region "Main contents"

        public override void OnRenderMain(FlatProject project, ParsedLog log)
        {
            int rowPos = LG_ROW_POS_CONTENT_START;

            foreach (ParsedLogLine line in log.LogLineList)
            {
                int colPos = LG_COL_POS_CONTENT_START;

                if (project.ShowFileName)
                {
                    ICell fileCell = GetLogContentStringCell(colPos, rowPos);
                    fileCell.SetCellValue(line.File.Name);
                    SetCellWidthToDictionary(LG_COL_NAME_FILE, line.File.Name);
                    colPos++;
                }

                ICell lineNumCell = GetLogContentCenterCell(colPos, rowPos);
                lineNumCell.SetCellValue(line.LineNumber);
                SetCellWidthToDictionary(LG_COL_NAME_LINE, line.LineNumber.ToString());
                colPos++;

                if (line.HasError)
                {
                    ICell notParsedCell = GetLogContentStringCell(colPos, rowPos);
                    notParsedCell.SetCellValue(line.NotParsedLog);

                    if (line.ColumnList.Count > 1)
                    {
                        int cellRange = colPos;
                        foreach (ParsedLogColumn col in line.ColumnList)
                        {
                            if (col.ColumnDefinition.Visble)
                            {
                                cellRange++;
                            }
                        }

                        CellRangeAddress region = new CellRangeAddress(rowPos, rowPos, colPos, cellRange - 1);
                        logSheet.AddMergedRegion(region);

                        RegionUtil.SetBorderTop(BORDER_THIN, region, logSheet, workbook);
                        RegionUtil.SetBorderBottom(BORDER_THIN, region, logSheet, workbook);
                        RegionUtil.SetBorderRight(BORDER_THIN, region, logSheet, workbook);
                        RegionUtil.SetBorderLeft(BORDER_THIN, region, logSheet, workbook);
                    }
                }
                else
                {
                    foreach (ParsedLogColumn col in line.ColumnList)
                    {
                        if (!col.ColumnDefinition.Visble)
                        {
                            continue;
                        }

                        ICell cell = null;

                        if (col.ColumnDefinition.IsDateTimeField)
                        {
                            DateTime time = new DateTime(long.Parse(col.Value));

                            cell = GetLogContentDateCell(colPos, rowPos);
                            cell.SetCellValue(time);
                            SetCellWidthToDictionary(col.ColumnDefinition.ColumnName, time.ToString(FORMAT_STR_DATE));
                        }
                        else
                        {
                            cell = GetLogContentStringCell(colPos, rowPos);
                            cell.SetCellValue(col.Value);
                            SetCellWidthToDictionary(col.ColumnDefinition.ColumnName, col.Value);
                        }

                        colPos++;
                    }
                }

                rowPos++;
            }

            ResizeLogColumns(project, project.PatternDefinition.ColumnDefinitionList);
        }

        #endregion

        #region "Footer"

        public override void OnRenderDocumentFooter(FlatProject project, ParsedLog log)
        {
            // Nothing to do
        }

        #endregion

        #endregion

        #region "Cell accessor"

        public ICell GetSummaryCell(int columnIndex, int rowIndex)
        {
            return GetCell(summarySheet, columnIndex, rowIndex);
        }

        public ICell GetLogHeaderCell(int columnIndex, int rowIndex)
        {
            ICell cell = GetCell(logSheet, columnIndex, rowIndex);
            cell.CellStyle = headerStyle;

            return cell;
        }

        public ICell GetLogContentStringCell(int columnIndex, int rowIndex)
        {
            ICell cell = GetCell(logSheet, columnIndex, rowIndex);
            cell.CellStyle = contentStringStyle;

            return cell;
        }

        public ICell GetLogContentCenterCell(int columnIndex, int rowIndex)
        {
            ICell cell = GetCell(logSheet, columnIndex, rowIndex);
            cell.CellStyle = contentStringCenterStyle;

            return cell;
        }

        public ICell GetLogContentDateCell(int columnIndex, int rowIndex)
        {
            ICell cell = GetCell(logSheet, columnIndex, rowIndex);
            cell.CellStyle = contentDateStyle;

            return cell;
        }

        private ICell GetCell(ISheet sheet, int columnIndex, int rowIndex)
        {
            IRow row = sheet.GetRow(rowIndex) ?? sheet.CreateRow(rowIndex);
            return row.GetCell(columnIndex) ?? row.CreateCell(columnIndex);
        }

        #endregion

        #region "Styles"

        private ICellStyle CreateTitleStyle()
        {
            IFont titleFont = workbook.CreateFont();
            titleFont.FontHeightInPoints = TITLE_FONT_SIZE;

            ICellStyle titleStyle = workbook.CreateCellStyle();
            titleStyle.SetFont(titleFont);

            return titleStyle;
        }

        private ICellStyle CreateHeaderStyle()
        {
            IFont headerFont = workbook.CreateFont();
            headerFont.Color = IndexedColors.White.Index;

            ICellStyle headerStyle = CreateBorderedStyle();
            headerStyle.SetFont(headerFont);
            headerStyle.FillPattern = FillPattern.SolidForeground;
            headerStyle.FillForegroundColor = IndexedColors.Grey50Percent.Index;
            headerStyle.Alignment = HorizontalAlignment.Center;

            return headerStyle;
        }

        private ICellStyle CreateBorderedStyle()
        {
            ICellStyle style = workbook.CreateCellStyle();
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;

            style.VerticalAlignment = VerticalAlignment.Center;

            style.WrapText = true;

            return style;
        }

        #endregion

        #region "Calc column size"

        private void SetCellWidthToDictionary(string colName, string value)
        {
            int width = CELL_WIDTH_BASE * value.Length + CELL_WIDTH_MARGIN;

            if (!maxCellWidthDictionary.ContainsKey(colName))
            {
                maxCellWidthDictionary.Add(colName, 0);
            }

            if (width > MAX_CELL_WIDTH)
            {
                maxCellWidthDictionary[colName] = MAX_CELL_WIDTH;
                return;
            }

            int maxWidth = maxCellWidthDictionary[colName];

            if (width > maxWidth)
            {
                maxCellWidthDictionary[colName] = width;
            }
        }

        private void ResizeLogColumns(FlatProject proj, ColumnDefinitionList colDefList)
        {
            int colPos = LG_COL_POS_CONTENT_START;

            if (proj.ShowFileName)
            {
                int fileColWidth = maxCellWidthDictionary[LG_COL_NAME_FILE];
                logSheet.SetColumnWidth(colPos, fileColWidth);
                colPos++;
            }

            int lineColWidth = maxCellWidthDictionary[LG_COL_NAME_LINE];
            logSheet.SetColumnWidth(colPos, lineColWidth);
            colPos++;

            foreach (ColumnDefinition colDef in colDefList)
            {
                if (!colDef.Visble)
                {
                    continue;
                }

                int width = maxCellWidthDictionary[colDef.ColumnName];
                logSheet.SetColumnWidth(colPos, width);
                colPos++;
            }
        }

        #endregion
    }
}
