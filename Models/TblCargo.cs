using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblCargo
    {
        public TblCargo()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int KargoId { get; set; }
        public string? Firma { get; set; }
        public string? FirmaKodu { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
