using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblMagazaFiyatlari
    {
        public TblMagazaFiyatlari()
        {
            TblUruns = new HashSet<TblUrun>();
        }

        public int MFiyatId { get; set; }
        public decimal? N11 { get; set; }
        public decimal? Trendyol { get; set; }
        public decimal? Hepsiburada { get; set; }
        public decimal? Amazon { get; set; }

        public virtual ICollection<TblUrun> TblUruns { get; set; }
    }
}
