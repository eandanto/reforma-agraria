using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace reformaagraria.Controllers
{
    public class FormController : Controller
    {
        public IActionResult FormTambahAcara()
        {
            return View();
        }

        public IActionResult FormKebijakanPustaka()
        {
            return View();
        }

        public IActionResult FormLaporanPertemuan()
        {
            return View();
        }

        public IActionResult FormProfilDesa()
        {
            return View();
        }

        public IActionResult FormTipologiPermasalahanAgraria()
        {
            return View();
        }

        public IActionResult FormBatasDesa()
        {
            return View();
        }
    }
}
