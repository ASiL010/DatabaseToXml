using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblProductHb
    {
        public int ProductHbId { get; set; }
        public string? CategoryId { get; set; }
        public string? Merchant { get; set; }
        public string? MerchantSku { get; set; }
        public string? VaryantGroupId { get; set; }
        public string? Barcode { get; set; }
        public string? UrunAdi { get; set; }
        public string? UrunAciklamasi { get; set; }
        public string? Marka { get; set; }
        public string? GarantiSuresi { get; set; }
        public string? Kg { get; set; }
        public string? TaxVatRate { get; set; }
        public string? Price { get; set; }
        public string? Stock { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }
        public string? RenkVariantProperty { get; set; }
        public string? EbatlarVariantProperty { get; set; }
        public string? MarkaTy { get; set; }
        public string? KategoriTy { get; set; }
        public string? ListeFiyatiTy { get; set; }
        public string? SatisFiyatiTy { get; set; }
        public bool? EksikDurum { get; set; }
        public string? MinFiyat { get; set; }
        public string? MaxFiyat { get; set; }
    }
}
