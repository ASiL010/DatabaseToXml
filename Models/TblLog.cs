using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblLog
    {
        public int LogId { get; set; }
        public int? UrunId { get; set; }
        public TimeSpan? Zaman { get; set; }
        public int? KullaniciId { get; set; }

        public virtual TblKullanici? Kullanici { get; set; }
        public virtual TblUrun? Urun { get; set; }
    }
}
