using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunIsim { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public bool SatistaMi { get; set; }
    }
}