using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Controllers
{
    public class OvertimeRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
