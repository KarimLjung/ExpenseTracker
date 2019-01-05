using System;
using System.IO;
using System.Linq;
using OfficeOpenXml;

namespace BLL
{
    public class ExcelLoaderService : IExcelLoaderService
    {
        public ExcelDto GetExcelDtoFromFile()
        {
            var excelFile = new FileInfo(@"C:\Temp\export.xlsx");
            using (var package = new ExcelPackage(excelFile))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets.First();
                var colCount = worksheet.Dimension.End.Column;  //get Column Count
                var rowCount = worksheet.Dimension.End.Row;     //get row count
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        var value = worksheet.Cells[row, col].Value.ToString().Trim();
                        Console.WriteLine(" Row:" + row + " column:" + col + " Value:" + worksheet.Cells[row, col].Value.ToString().Trim());
                    }
                }
            }

                throw new NotImplementedException();
        }
    }
}
