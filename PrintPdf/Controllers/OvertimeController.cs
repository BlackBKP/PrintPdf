using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Controllers
{
    public class OvertimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
