using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblÜrünkargoteslim
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string? Kargogönderimtarihi { get; set; }
        public string? Siparişnumarası { get; set; }
        public string? Pazaryeri { get; set; }
        public string? Kullanici { get; set; }
        public string? Resimyol { get; set; }
    }
}
