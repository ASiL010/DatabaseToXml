using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerSaticiResim
    {
        public int DigerSaticiResimId { get; set; }
        public string? Url { get; set; }
        public int? DigerSaticiUrunId { get; set; }

        public virtual TblDigerSaticiUrun DigerSaticiResim { get; set; } = null!;
    }
}
