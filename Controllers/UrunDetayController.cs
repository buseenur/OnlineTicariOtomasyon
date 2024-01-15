using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        public IActionResult Index()
        {
            //var degerler = c.Uruns.Where(x => x.UrunID == 1).ToList();
            Class1 cs = new Class1();
            cs.Deger1 = c.Uruns.Where(x => x.UrunID == 1).ToList();
            cs.Deger2 = c.Detays.Where(y => y.DetayID == 1).ToList();
            return View(cs);
        }
    }
}

