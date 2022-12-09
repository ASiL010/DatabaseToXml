using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblKullanici
    {
        public TblKullanici()
        {
            TblLogs = new HashSet<TblLog>();
        }

        public int KullaniciId { get; set; }
        public string? KAd { get; set; }
        public string? KSif { get; set; }
        public string? Tur { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? KayitTarihi { get; set; }

        public virtual ICollection<TblLog> TblLogs { get; set; }
    }
}
