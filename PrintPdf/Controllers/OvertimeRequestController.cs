using Microsoft.AspNetCore.Mvc;
using PrintPdf.Models;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Controllers
{
    public class OvertimeRequestController : Controller
    {
        static List<FormOvertimeRequestModel> requests;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<FormOvertimeRequestModel> GetRequests()
        {
            requests = new List<FormOvertimeRequestModel>();
            FormOvertimeRequestModel req1 = new FormOvertimeRequestModel()
            {
                form_id = "2022APR0001",
                employee_name = "Korakod Phongdee",
                job_id = "J999999",
                location = "HQ",
                site_name = null,
                withdrawal = true,
                normal_start_date = new DateTime(2022, 4, 1),
                normal_stop_date = new DateTime(2022,4,30),
                normal_start_time = new TimeSpan(17,30,0),
                normal_stop_time = new TimeSpan(22,0,0),
                offday_start_date = new DateTime(2022, 4, 1),
                offday_stop_date = new DateTime(2022, 4, 30),
                offday_start_time = new TimeSpan(8, 30, 0),
                offday_stop_time = new TimeSpan(17, 30, 0),
                objective = "TEST PRINT REPORT"
            };
            requests.Add(req1);

            FormOvertimeRequestModel req2 = new FormOvertimeRequestModel()
            {
                form_id = "2022APR0002",
                employee_name = "Korakod Phongdee",
                job_id = "J000001",
                location = "Site",
                site_name = "Ladkrabang",
                withdrawal = false,
                normal_start_date = new DateTime(2022, 4, 1),
                normal_stop_date = new DateTime(2022, 4, 30),
                normal_start_time = new TimeSpan(17, 30, 0),
                normal_stop_time = new TimeSpan(22, 0, 0),
                offday_start_date = new DateTime(2022, 4, 1),
                offday_stop_date = new DateTime(2022, 4, 30),
                offday_start_time = new TimeSpan(8, 30, 0),
                offday_stop_time = new TimeSpan(17, 30, 0),
                objective = "TEST PRINT REPORT 2"
            };
            requests.Add(req2);
            return requests;
        }

        public IActionResult RequestForm(string req_id)
        {
            FormOvertimeRequestModel request = requests.Where(w => w.form_id == req_id).FirstOrDefault();
            return View(request);
        }

        [HttpGet]
        public IActionResult PrintRequestForm(string req_id)
        {
            RequestForm(req_id);
            return new ViewAsPdf("RequestForm", req_id);
        }
    }
}
