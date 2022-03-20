using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.Departman.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmanEkle(Departman d)
        {
            return View();
        }
    }
}
