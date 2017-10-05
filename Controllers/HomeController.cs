using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reformaagraria.Data;

namespace reformaagraria.Controllers
{
    public class HomeController : Controller
    {
        private readonly RADataContext db;
        public HomeController(RADataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
