using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}

