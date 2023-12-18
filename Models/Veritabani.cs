using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public static class Veritabani
    {
        private static List<Urun> _liste;

        static Veritabani()
        {
            _liste = new List<Urun>()
            {
                new Urun() {UrunId = 1, UrunIsim = "Iphone 12", Aciklama = "orta", Fiyat = 28000, SatistaMi = true  },
                new Urun() {UrunId = 2, UrunIsim = "Iphone 13 Pro", Aciklama = "iyi-çok iyi", Fiyat = 32000, SatistaMi = false },
                new Urun() {UrunId = 3, UrunIsim = "Iphone 14", Aciklama = "iyi-çok iyi", Fiyat = 35000, SatistaMi = true },
                new Urun() {UrunId = 4, UrunIsim = "Iphone 12 Pro Max", Aciklama = "iyi", Fiyat = 30000, SatistaMi = true },
                new Urun() {UrunId = 5, UrunIsim = "Iphone 13", Aciklama = "iyi", Fiyat = 25000, SatistaMi = true },
                new Urun() {UrunId = 6, UrunIsim = "Iphone 11", Aciklama = "kötü-orta", Fiyat = 19000, SatistaMi = false },
                new Urun() {UrunId = 7, UrunIsim = "Samsung S23", Aciklama = "iyi-çok iyi", Fiyat = 30000, SatistaMi = true },
                new Urun() {UrunId = 8, UrunIsim = "Samsung S22", Aciklama = "iyi", Fiyat = 25000, SatistaMi = true },
                new Urun() {UrunId = 9, UrunIsim = "Samsung S22+", Aciklama = "iyi-çok iyi", Fiyat = 20000, SatistaMi = false },

            };
        }

        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }

        public static Urun UrunDetay(int urunId)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if (urun.UrunId == urunId)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}