using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTicariOtomasyon.Controllers
{
    public class CariPanelController : Controller
    {
        // GET: /<controller>/
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            //var mail = (string)Session["CariMail"];
            //var degerler = c.Carilers.FirstOrDefault(x => x.CariMail == mail);
            //return View(degerler);
            return View();
        }
    }
}

