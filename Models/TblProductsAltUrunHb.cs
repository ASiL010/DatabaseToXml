using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblProductsAltUrunHb
    {
        public int ProductHbsId { get; set; }
        public string? MerchantSku { get; set; }
        public string? VaryantGroupId { get; set; }
        public string? Barcode { get; set; }
        public string? Stok { get; set; }
        public int? ProductId { get; set; }
        public int? Durum { get; set; }
        public int? ProductId2 { get; set; }
        public string? Fiyat { get; set; }
        public string? MaxFiyat { get; set; }
        public string? MinFiyat { get; set; }
        public string? UrunAdi { get; set; }
        public string? UrunAciklamasi { get; set; }
        public bool? Durum2 { get; set; }
    }
}
