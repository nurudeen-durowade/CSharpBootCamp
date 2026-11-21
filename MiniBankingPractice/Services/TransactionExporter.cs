using System;
using System.Globalization;
using System.IO;
using MiniBankingPractice.Models;
using System.Collections.Generic;
using ClosedXML.Excel;

public class TransactionExporter : IDisposable
{
    public void Export (IEnumerable<Transaction> transactions, string filepath)
    {

        ArgumentNullException.ThrowIfNull(transactions, nameof(transactions));

         if (string.IsNullOrWhiteSpace(filepath))
             throw new ArgumentException("File path cannot be null or empty.", nameof(filepath));

        // Ensure the directory for the file path exists
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Transactions");
        worksheet.Cell(1, 1).Value = "TransactionType";
        worksheet.Cell(1, 2).Value = "Amount";
        worksheet.Cell(1, 3).Value = "CreatedAt";

        int row = 2;

        foreach(var transaction in transactions)
        {
            worksheet.Cell(row, 1).Value = transaction.Type.ToString();
            worksheet.Cell(row, 2).Value = transaction.Amount;
            worksheet.Cell(row, 3).Value = transaction.CreatedAt;
            row++;
        }

        // Format the header row to be bold
        var headerRow = worksheet.Row(1);
        headerRow.Style.Font.Bold = true;

        // Adjust column widths to fit content
        worksheet.Columns().AdjustToContents();
        worksheet.Column(3).Style.DateFormat.Format = "yyyy-mm-dd hh:mm:ss";


//Save the workbook to the specified file path
        workbook.SaveAs(filepath);
    }
    public void Dispose()
    {
        // Dispose of any resources if necessary
    }
}