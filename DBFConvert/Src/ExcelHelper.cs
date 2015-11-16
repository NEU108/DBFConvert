using System.Data;
using Aspose.Cells;

namespace DBFConvert
{
    public class ExcelHelper
    {
        public static void TableToExcelAspose03(DataTable dt, string saveFileName)
        {
            Workbook workbook = new Workbook();
            workbook.FileFormat = FileFormatType.Excel97To2003;
            Worksheet cellSheet = workbook.Worksheets[0];

            int rowIndex = 0;
            int colIndex = 0;
            int colCount = dt.Columns.Count;
            int rowCount = dt.Rows.Count;

            //表头列名的处理  
            for (int i = 0; i < colCount; i++)
            {
                cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Columns[i].ColumnName); ;
                colIndex++;
            }

            //数据处理
            rowIndex++;
            for (int i = 0; i < rowCount; i++)
            {
                colIndex = 0;
                for (int j = 0; j < colCount; j++)
                {
                    cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Rows[i][j].ToString());
                    colIndex++;
                }
                rowIndex++;
            }

            //自适应列
            //cellSheet.AutoFitColumns();
            workbook.Save(saveFileName);
        }

        public static void TableToExcelAspose07(DataTable dt, string saveFileName)
        {
            Workbook workbook = new Workbook();
            workbook.FileFormat = FileFormatType.Xlsx;
            Worksheet cellSheet = workbook.Worksheets[0];

            int rowIndex = 0;
            int colIndex = 0;
            int colCount = dt.Columns.Count;
            int rowCount = dt.Rows.Count;

            //表头列名的处理  
            for (int i = 0; i < colCount; i++)
            {
                cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Columns[i].ColumnName);
                colIndex++;
            }

            //数据处理
            rowIndex++;
            for (int i = 0; i < rowCount; i++)
            {
                colIndex = 0;
                for (int j = 0; j < colCount; j++)
                {
                    cellSheet.Cells[rowIndex, colIndex].PutValue(dt.Rows[i][j].ToString());
                    colIndex++;
                }
                rowIndex++;
            }

            //自适应列
            //cellSheet.AutoFitColumns();
            workbook.Save(saveFileName);
        }
    }
}
