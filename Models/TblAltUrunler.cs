using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblAltUrunler
    {
        public int AltUrunId { get; set; }
        public string? AltUrunAdi { get; set; }
        public int? UrunId { get; set; }
        public decimal? Fiyat { get; set; }

        public virtual TblUrun? Urun { get; set; }
    }
}
