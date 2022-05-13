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
        static FormOvertimeRequestModel req;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Report()
        {
            var OvertimeReport = new ViewAsPdf("Report")
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                ViewName = "Overtime",
            };
            return OvertimeReport;
        }

        public IActionResult DailyReport()
        {
            var DailyReport = new ViewAsPdf("DailyReport")
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                ViewName = "DailyReport",
            };
            return DailyReport;
        }

        public IActionResult OvertimeRequest()
        {
            var OvertimeRequest = new ViewAsPdf("OvertimeRequest")
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                ViewName = "OvertimeRequest",
            };
            return OvertimeRequest;
        }

        [HttpPost]
        public string UpdateReportData(string req_id)
        {
            req = new FormOvertimeRequestModel();
            req.form_id = req_id;
            return "Success";
        }

        public IActionResult DynamicReport()
        {
            req.employee_name = "Korakod.P";
            var DynamicReport = new ViewAsPdf("DynamicReport")
            {
                Model = req,
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                ViewName = "DynamicReport",
            };
            return DynamicReport;
        }
    }
}
