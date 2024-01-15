using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        // GET: /<controller>/

        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Carilers.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult CariEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CariEkle(Cariler p)
        {
            p.Durum=true;
            c.Carilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CariSil(int id)
        {
            var cr = c.Carilers.Find(id);
            cr.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CariGetir(int id)
        {
            var cr = c.Carilers.Find(id);

            return View("CariGetir",cr);
        }

        public IActionResult CariGuncelle(Cariler p)
        {

            if (!ModelState.IsValid)
            {
                return View("CariGetir");
            }

            var car = c.Carilers.Find(p.CariID);
            car.CariAd = p.CariAd;
            car.CariSoyad = p.CariSoyad;
            car.CariSehir = p.CariSehir;
            car.CariMail = p.CariMail;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult MusteriSatis(int id)
        {
            var deger = c.SatisHarekets.Include(x => x.Urun).Include(x => x.Personel).Where(x => x.Cariid == id).ToList();
            var deg = c.Carilers.Where(x => x.CariID == id).Select(x => x.CariAd + " " + x.CariSoyad).FirstOrDefault();
            ViewBag.dp = deg;
            return View(deger);
        }
    }
}

