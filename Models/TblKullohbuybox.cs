using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblKullohbuybox
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Kad { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }
        public decimal? Fark { get; set; }
        public bool? Otomanuel { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Marka { get; set; }
        public decimal? Sonfiyat { get; set; }
    }
}
