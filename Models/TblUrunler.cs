using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblUrunler
    {
        public TblUrunler()
        {
            TblCikis = new HashSet<TblCiki>();
        }

        public string UrunBarkod { get; set; } = null!;
        public string? UrunFoto { get; set; }
        public string? UrunAd { get; set; }
        public int? UrunFiyat { get; set; }
        public string? Kod { get; set; }

        public virtual ICollection<TblCiki> TblCikis { get; set; }
    }
}
