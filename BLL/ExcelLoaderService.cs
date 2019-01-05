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
            }

                throw new NotImplementedException();
        }
    }
}
