using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public class UrunKategoriModel
    {
        public int urunSayisi { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}