using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblProduct
    {
        public int UrunId { get; set; }
        public string? CategoryId { get; set; }
        public string? MerchantIdHb { get; set; }
        public string? Attribute { get; set; }
        public string? SaticiSku { get; set; }
        public string? VaryantGrupIdHb { get; set; }
        public string? UrunAdi { get; set; }
        public int? DescreptionId { get; set; }
        public string? Barkod { get; set; }
        public string? BarcodeTy { get; set; }
        public string? MarkaHb { get; set; }
        public int? BrandIdTy { get; set; }
        public string? GarantiSuresiHb { get; set; }
        public string? Agirlik { get; set; }
        public string? Adet { get; set; }
        public string? CurrencyTypeTy { get; set; }
        public string? CargoCompanyIdTy { get; set; }
        public string? AttributeNHb { get; set; }
        public string? VatRateTy { get; set; }
        public int? ResimId { get; set; }
        public int? FiyatId { get; set; }
        public int? KargoId { get; set; }

        public virtual TblPrice? Fiyat { get; set; }
        public virtual TblCargo? Kargo { get; set; }
        public virtual TblPicture? Resim { get; set; }
    }
}
