using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerUrunSaticiNm
    {
        public int DigerUrunSaticiNmId { get; set; }
        public int? DigerSaticiId { get; set; }
        public int? DigerSaticiUrunId { get; set; }

        public virtual TblDigerSatici? DigerSatici { get; set; }
        public virtual TblDigerSaticiUrun? DigerSaticiUrun { get; set; }
    }
}
