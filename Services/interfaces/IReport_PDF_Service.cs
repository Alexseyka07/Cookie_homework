namespace progtime_hm.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

public interface IReport_PDF_Service
{
    FileStreamResult GenerateReport_PDF(string reportData);
}
