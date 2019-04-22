using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoalKe_2.Models;

namespace SoalKe_2.Controllers
{
    public class HitungController : Controller
    {
        [HttpGet]
        public IActionResult Hitung()
        {
            PersegiPanjang pp = new PersegiPanjang();
            return View(pp);
        }

        [HttpPost]
        public IActionResult Hitung(PersegiPanjang pp)
        {
            return View(pp);
        }

    }
}