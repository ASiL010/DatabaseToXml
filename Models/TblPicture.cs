using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblPicture
    {
        public TblPicture()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int ResimId { get; set; }
        public string? Url1 { get; set; }
        public string? Url2 { get; set; }
        public string? Url3 { get; set; }
        public string? Url4 { get; set; }
        public string? Url5 { get; set; }
        public string? Url6 { get; set; }
        public string? Url7 { get; set; }
        public string? Url8 { get; set; }
        public string? Url9 { get; set; }
        public string? Url10 { get; set; }
        public int? UrunId { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
