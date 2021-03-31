using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace campusproject.Controllers
{
    public class ascompanyController : Controller
    {
        public IActionResult Cindex()
        {
            return View();
        }
        public IActionResult Cnoti()
        {
            return View();
        }
    }
}
