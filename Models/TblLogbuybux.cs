using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblLogbuybux
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Fiyat { get; set; }
        public string? Bilgi { get; set; }
        public string? Count { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
