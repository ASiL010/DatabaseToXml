using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblKategori
    {
        public TblKategori()
        {
            TblUruns = new HashSet<TblUrun>();
        }

        public int KategoriId { get; set; }
        public string? Kategori { get; set; }
        public int? AltKategoriId { get; set; }

        public virtual TblAltKategori? AltKategori { get; set; }
        public virtual ICollection<TblUrun> TblUruns { get; set; }
    }
}
