using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerSaticiUrun
    {
        public TblDigerSaticiUrun()
        {
            TblDigerSaticiFiyats = new HashSet<TblDigerSaticiFiyat>();
            TblDigerSaticiTagLists = new HashSet<TblDigerSaticiTagList>();
            TblDigerUrunSaticiNms = new HashSet<TblDigerUrunSaticiNm>();
        }

        public int DigerSaticiUrunId { get; set; }
        public string? Name { get; set; }
        public string? ProductId { get; set; }
        public string? Sku { get; set; }
        public string? DefaultSku { get; set; }

        public virtual TblDigerSaticiResim TblDigerSaticiResim { get; set; } = null!;
        public virtual ICollection<TblDigerSaticiFiyat> TblDigerSaticiFiyats { get; set; }
        public virtual ICollection<TblDigerSaticiTagList> TblDigerSaticiTagLists { get; set; }
        public virtual ICollection<TblDigerUrunSaticiNm> TblDigerUrunSaticiNms { get; set; }
    }
}
