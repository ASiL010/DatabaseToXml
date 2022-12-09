using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblPaketTempTy
    {
        public int PaketId { get; set; }
        public string? UrunAd { get; set; }
        public string? MAd { get; set; }
        public string? Tysku { get; set; }
        public string? KargoFirmasi { get; set; }
        public string? SiparisNo { get; set; }
        public string? Barkod { get; set; }
        public string? LinesSku { get; set; }
        public string? Adet { get; set; }
        public string? Fiyat { get; set; }
        public string? VergiNo { get; set; }
        public string? Il { get; set; }
        public string? Ilçe { get; set; }
        public string? Semt { get; set; }
        public string? Tamadres { get; set; }
        public string? Magaza { get; set; }
        public string? Id { get; set; }
        public bool? Basilmadurumu { get; set; }
        public string? Adres { get; set; }
        public DateTime? Kayittarihi { get; set; }
    }
}
