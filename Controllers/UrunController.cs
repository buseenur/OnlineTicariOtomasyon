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
    public class UrunController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        public IActionResult Index()
        {
            var urun = c.Uruns.Include(x=>x.Kategori).Where(x => x.Durum == true).ToList();
            return View(urun);
        }

        [HttpGet]
        public IActionResult UrunEkle()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }

        [HttpPost]
        public IActionResult UrunEkle(Urun u)
        {
            c.Uruns.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UrunSil(int id)
        {
            var urn = c.Uruns.Find(id);
            urn.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList() ;
            ViewBag.dgr1 = deger1;

            var urundeger = c.Uruns.Find(id);
            return View("UrunGetir",urundeger);
        }

        public IActionResult UrunGuncelle (Urun u)
        {
            var urn = c.Uruns.Find(u.UrunID);

            urn.Kategoriid = u.Kategoriid;
            urn.AlisFiyat = u.AlisFiyat;
            urn.SatisFiyat = urn.SatisFiyat;
            urn.Marka = u.Marka;
            urn.Durum = u.Durum;
            urn.Stok = u.Stok;
            urn.UrunAd = u.UrunAd;
            urn.UrunGorsel = u.UrunGorsel;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UrunListesi()
        {
            var degerler = c.Uruns.Include(x => x.Kategori).ToList();
            return View(degerler);
        }
    }
}

