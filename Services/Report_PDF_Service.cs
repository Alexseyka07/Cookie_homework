namespace progtime_hm.Services;
using progtime_hm.Services.interfaces;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

using System.IO;

public class Report_PDF_Service : IReport_PDF_Service
{
    public FileStreamResult GenerateReport_PDF(string reportData)
    {
        var ms = new MemoryStream();
        var doc = new Document();
        var writer = PdfWriter.GetInstance(doc, ms);
    
        doc.Open();
    
        var paragraph = new Paragraph(reportData);
        doc.Add(paragraph);
    
        ms.Position = 0; // Move this line here
    
        doc.Close();
    
        return new FileStreamResult(ms, "application/pdf")
        {
            FileDownloadName = "report.pdf"
        };
    }
}