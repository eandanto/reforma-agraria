using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reforma_agraria.Data;

namespace reforma_agraria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReformaAgrariaDbContext db;
        public HomeController(ReformaAgrariaDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
