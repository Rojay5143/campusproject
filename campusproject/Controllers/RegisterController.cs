using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using campusproject.Models;

namespace campusproject.Controllers
{
    public class RegisterController : Controller
    {
               public IActionResult Sregister()
        {
            return View();
        }

      
    }
}
