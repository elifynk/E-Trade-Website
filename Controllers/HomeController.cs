using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.urunSayisi = Veritabani.Liste.Where(i => i.SatistaMi == true).Count();
            model.Urunler = Veritabani.Liste.Where(i => i.SatistaMi == true).ToList();

            //ViewBag.urunSayisi = urunler.Count();
            //ViewBag.kategoriler = Kategoriler;

            return View(model);
        }
        public ActionResult Details(int id)
        {
            var urun = Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();

            return View(urun);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(string UrunIsim, string Aciklama, double Fiyat, bool SatistaMi)
        {
            Urun entity = new Urun();
            entity.UrunIsim = UrunIsim;
            entity.Aciklama = Aciklama;
            entity.Fiyat = Fiyat;
            entity.SatistaMi = SatistaMi;

            Veritabani.ElemanEkle(entity);

            return View("UrunListe", Veritabani.Liste);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}