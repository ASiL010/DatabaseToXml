using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblUruntosku
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Ürünad { get; set; }
        public string? Resimyol { get; set; }
        public bool? Durum { get; set; }
    }
}
