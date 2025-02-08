// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

Console.WriteLine("Hello, World!");

string excelFilePath = @"C:\sql.xlsx"; // Excel faylının tam yolunu yazın
string outputSqlPath = @"C:\a.sql"; // SQL faylı harda saxlanacaq
string tableName = "Employees"; // SQL cədvəl adı

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
{
    var worksheet = package.Workbook.Worksheets[0]; // İlk səhifəni seçirik
    int rowCount = worksheet.Dimension.Rows; // Sətir sayı
    int colCount = worksheet.Dimension.Columns; // Sütun sayı

    using (StreamWriter writer = new StreamWriter(outputSqlPath))
    {
        for (int row = 2; row <= rowCount; row++) // 1-ci sətir başlıqlardır, ona görə 2-dən başlayırıq
        {
            var values = new string[colCount];

            for (int col = 1; col <= colCount; col++)
            {
                object cellValue = worksheet.Cells[row, col].Value;
                values[col - 1] = cellValue != null ? $"'{cellValue.ToString().Replace("'", "''")}'" : "NULL";
            }

            string sqlQuery = $"INSERT INTO {tableName} VALUES ({string.Join(", ", values)});";
            writer.WriteLine(sqlQuery);
        }
    }
}

Console.WriteLine("SQL faylı yaradıldı: " + outputSqlPath);