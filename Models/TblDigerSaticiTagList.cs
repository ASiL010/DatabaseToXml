using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerSaticiTagList
    {
        public int DigerSaticiTagId { get; set; }
        public string? Tag { get; set; }
        public int? DigerSaticiUrunId { get; set; }

        public virtual TblDigerSaticiUrun? DigerSaticiUrun { get; set; }
    }
}
