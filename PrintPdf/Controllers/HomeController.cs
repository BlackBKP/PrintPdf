using Microsoft.AspNetCore.Mvc;
using PrintPdf.Models;
using Rotativa;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult PrintReport()
        {
            return new ViewAsPdf("Report");
        }

        public IActionResult DailyReport()
        {
            return View();
        }

        public IActionResult PrintDailyReport()
        {
            return new ViewAsPdf("DailyReport");
        }

        public IActionResult OvertimeRequest()
        {
            return View();
        }

        public IActionResult PrintOvertimeRequest()
        {
            return new ViewAsPdf("OvertimeRequest");
        }
    }
}
