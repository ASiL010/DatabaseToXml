using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblUrun
    {
        public TblUrun()
        {
            TblAltUrunlers = new HashSet<TblAltUrunler>();
            TblLogs = new HashSet<TblLog>();
        }

        public int UrunId { get; set; }
        public string? UrunAd { get; set; }
        public string? AltAd { get; set; }
        public string? Barkod { get; set; }
        public string? VaryantBarkod { get; set; }
        public int? UrunKdv { get; set; }
        public int? Yil { get; set; }
        public string? Aciklama { get; set; }
        public string? UrunKodu { get; set; }
        public int? Stok { get; set; }
        public bool? StokDurum { get; set; }
        public bool? UrunDurum { get; set; }
        public int? KategoriId { get; set; }
        public int? MFiyatId { get; set; }
        public int? MarkaId { get; set; }
        public int? FaturaId { get; set; }
        public int? OzellikId { get; set; }
        public int? DurumId { get; set; }
        public string? EklemeTipi { get; set; }

        public virtual TblDurum? Durum { get; set; }
        public virtual TblFatura? Fatura { get; set; }
        public virtual TblKategori? Kategori { get; set; }
        public virtual TblMagazaFiyatlari? MFiyat { get; set; }
        public virtual TblMarka? Marka { get; set; }
        public virtual ICollection<TblAltUrunler> TblAltUrunlers { get; set; }
        public virtual ICollection<TblLog> TblLogs { get; set; }
    }
}
