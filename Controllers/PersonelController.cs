using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x => x.Departman).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.DepartmanID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel p)
        {
            c.Personels.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult PersonelGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.DepartmanID.ToString()
                                           }).ToList();
            ViewBag.dp = deger1;
            var per = c.Personels.Find(id);
            ViewBag.per = per.PersonelAd + " " + per.PersonelSoyad;
            return View("PersonelGetir",per);
        }

        public IActionResult PersonelGuncelle(Personel p)
        {
            var per = c.Personels.Find(p.PersonelID);
            per.PersonelAd = p.PersonelAd;
            per.PersonelSoyad = p.PersonelSoyad;
            per.PersonelGorsel = p.PersonelGorsel;
            per.Departmanid = p.Departmanid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelListe()
        {
            var sorgu = c.Personels.ToList();

            return View(sorgu);
        }
    }
}

