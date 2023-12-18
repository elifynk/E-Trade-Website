using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class KategoriController : Controller
    {      // GET: Kategori
        public class HomeController : Controller
        {
            // GET: Home
            public ActionResult Index()
            {
                return View();
            }

            [ChildActionOnly]
            public PartialViewResult KategoriMenu()
            {
                List<Kategoriler> Kategoriler = new List<Kategoriler>()
                {
                new Kategoriler() { id = 1, kategoriAdi = "Telefon"},
                new Kategoriler() { id = 2, kategoriAdi = "Tablet" },
                new Kategoriler() { id = 3, kategoriAdi = "Laptop" },
                };
                
                return PartialView("KategoriMenu", Kategoriler);
            }
        }

    }
}