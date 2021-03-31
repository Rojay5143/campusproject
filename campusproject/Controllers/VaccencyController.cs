using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace campusproject.Controllers
{
    public class vaccencyController : Controller
    {
        public IActionResult vindex()
        {
            return View();
        }
    }
}
