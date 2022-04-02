using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Admin a)
        {
            var bilgiler = c.Admin.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.KullamiciSifre == a.KullamiciSifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim> 
                {
                    new Claim(ClaimTypes.Name, a.KullaniciAdi)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personel");
            }
            return View();
        }

    }
}
