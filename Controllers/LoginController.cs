using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Partial1(Cariler p)
        {
            c.Carilers.Add(p);
            c.SaveChanges();
            return PartialView();
        }

        [HttpGet]
        public IActionResult CariLogin1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CariLogin1(Cariler p)
        {
            var bilgiler = c.Carilers.FirstOrDefault(x => x.CariMail == p.CariMail && x.CariSifre == p.CariSifre);
            if (bilgiler != null )
            {
                
                return RedirectToAction("Index", "CariPanel");
            }

            else
            {
                return RedirectToAction("Index","Login");
            }
            
        }
    }
}

