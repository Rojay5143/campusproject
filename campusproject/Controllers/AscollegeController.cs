using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace campusproject.Controllers
{
    public class AscollegeController : Controller
    {
        public IActionResult Cgindex()
        {
            return View();
        }
    }
}
