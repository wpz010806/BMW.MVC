using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarBMW.MVC.Controllers
{
    public class Interface : Controller
    {
        public IActionResult Inter()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
