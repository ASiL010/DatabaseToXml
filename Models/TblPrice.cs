using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblPrice
    {
        public TblPrice()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int FiyatId { get; set; }
        public string? FiyatHb { get; set; }
        public string? FiyatTy { get; set; }
        public string? UstuCiziliFiyatTy { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
