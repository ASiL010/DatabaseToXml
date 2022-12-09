using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblOzellikler
    {
        public int? OzellikId { get; set; }
        public int? HacimId { get; set; }
        public int? NumaraId { get; set; }
        public int? RenkId { get; set; }
        public int? AgirlikId { get; set; }
        public int? Stok { get; set; }

        public virtual TblAgirlik? Agirlik { get; set; }
        public virtual TblHacim? AgirlikNavigation { get; set; }
        public virtual TblNumara? Numara { get; set; }
        public virtual TblUrun? Ozellik { get; set; }
        public virtual TblRenk? Renk { get; set; }
    }
}
