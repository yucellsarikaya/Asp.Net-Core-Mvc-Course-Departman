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
            c.Departman.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departman.Find(id);
            c.Departman.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var dep = c.Departman.Find(id);
            return View("DepartmanGetir", dep);
        }

        public IActionResult DepartmanGuncelle(Departman d)
        {
            var dep = c.Departman.Find(d.Id);
            dep.DepartmanAd = d.DepartmanAd;
            c.Departman.Update(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
