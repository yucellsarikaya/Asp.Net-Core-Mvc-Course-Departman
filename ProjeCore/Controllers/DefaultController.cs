using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birim.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniBirim(Birim d)
        {
            c.Birim.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimSil(int id)
        {
            var dep = c.Birim.Find(id);
            c.Birim.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimGetir(int id)
        {
            var dep = c.Birim.Find(id);
            return View("BirimGetir", dep);
        }

        public IActionResult BirimGuncelle(Birim d)
        {
            var dep = c.Birim.Find(d.BirimID);
            dep.BirimAd = d.BirimAd;
            c.Birim.Update(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
