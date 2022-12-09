using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblMarka
    {
        public TblMarka()
        {
            TblModels = new HashSet<TblModel>();
            TblUruns = new HashSet<TblUrun>();
        }

        public int MarkaId { get; set; }
        public string? Marka { get; set; }

        public virtual ICollection<TblModel> TblModels { get; set; }
        public virtual ICollection<TblUrun> TblUruns { get; set; }
    }
}
