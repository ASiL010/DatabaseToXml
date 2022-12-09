using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblUrunlertolink
    {
        public int Id { get; set; }
        public string? SaticiStokKodu { get; set; }
        public string? Sku { get; set; }
        public string? UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public string? EnAltKategori { get; set; }
        public string? AnaKategori { get; set; }
        public string? EnTemelKategori { get; set; }
        public string? Marka { get; set; }
        public string? Resimyol { get; set; }
        public bool? Durum { get; set; }
        public bool? Kayitdurum { get; set; }
    }
}
