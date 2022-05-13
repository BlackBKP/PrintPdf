using Microsoft.AspNetCore.Mvc;
using PrintPdf.Models;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DemoViewAsPDF()
        {
            var DemoForm = new ViewAsPdf("DemoViewAsPDF")
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                PageMargins = { Left = 15, Top = 20, Right = 10, Bottom = 10 },
                PageSize = Rotativa.AspNetCore.Options.Size.A5,
            };
            return DemoForm;
        }

        public IActionResult DemoModelPDF()
        {
            List<Customer> customerList = new List<Customer>()
            {
                 new Customer { CustomerID = 1, Address = "Taj Lands Ends 1", City = "Mumbai" , Country ="India", Name ="Sai", Phoneno ="9000000000"},
                 new Customer { CustomerID = 2, Address = "Taj Lands Ends 2", City = "Mumbai" , Country ="India", Name ="Ram", Phoneno ="9000000000"},
                 new Customer { CustomerID = 3, Address = "Taj Lands Ends 3", City = "Mumbai" , Country ="India", Name ="Sainesh", Phoneno ="9000000000"},
                 new Customer { CustomerID = 4, Address = "Taj Lands Ends 4", City = "Mumbai" , Country ="India", Name ="Saineshwar", Phoneno ="9000000000"},
                 new Customer { CustomerID = 5, Address = "Taj Lands Ends 5", City = "Mumbai" , Country ="India", Name ="Saibags", Phoneno ="9000000000"}
            };
            return new ViewAsPdf("DemoModelPDF", customerList);
        }
    }
}
