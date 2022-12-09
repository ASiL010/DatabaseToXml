using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblCiki
    {
        public int Id { get; set; }
        public string? SiparisNo { get; set; }
        public string? KalemSayisi { get; set; }
        public string? ToplamFiyat { get; set; }
        public string? SiparisDurumu { get; set; }
        public string? Pazaryeri { get; set; }
        public string? KargoyaSonVerme { get; set; }
        public string? KargoFirmaAdı { get; set; }
        public string? MusteriAd { get; set; }
        public string? TeslimatAdres { get; set; }
        public string? Barkod { get; set; }

        public virtual TblUrunler? BarkodNavigation { get; set; }
    }
}
