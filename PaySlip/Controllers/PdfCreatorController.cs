using BusinessLayer;
using BusinessLayer.DataModels;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PaySlip.Models.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace PaySlip.Controllers
{
    public class PdfCreatorController : Controller
    {
        private readonly IConfiguration configuration;
        private IConverter _converter;
        public PdfCreatorController(IConverter converter, IConfiguration config)
        {
            _converter = converter;
            this.configuration = config;

        }

        [HttpGet]
        public IActionResult CreatePDF(int userId, int month, int year, int salaryId)
        {
            SalaryBusinessLayer salaryBusiness = new SalaryBusinessLayer(configuration.GetConnectionString("ISODataBaseConnection"));            
            var payslip = salaryBusiness.GeneratePaySlip(salaryId, userId, month, year);
           
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A5,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                //Out = @"D:\PDF\Report.pdf"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(payslip),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },                
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

              var file = _converter.Convert(pdf);
              return File(file, "application/pdf");
        }
    }
}
       