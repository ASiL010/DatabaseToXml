using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblFatura
    {
        public TblFatura()
        {
            TblUruns = new HashSet<TblUrun>();
        }

        public int FaturaId { get; set; }
        public decimal? EFaturaSeri { get; set; }
        public decimal? EArsivSeri { get; set; }
        public decimal? KargoKodu { get; set; }
        public decimal? KargoVergiNo { get; set; }
        public int? UrunId { get; set; }
        public string? WebSiteUrl { get; set; }
        public string? KdvIstisnaDurum { get; set; }
        public string? FaturaTipi { get; set; }
        public string? EFaturaTipi { get; set; }
        public int? FirmaId { get; set; }
        public int? KullaniciId { get; set; }

        public virtual TblMusteri? Firma { get; set; }
        public virtual ICollection<TblUrun> TblUruns { get; set; }
    }
}
