using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerSaticiFiyat
    {
        public int DigerSaticiFiyatId { get; set; }
        public string? PriceText { get; set; }
        public string? VatExcludedPriceText { get; set; }
        public string? SortPriceText { get; set; }
        public string? OriginalPriceText { get; set; }
        public string? MinimumPriceText { get; set; }
        public int? DigerSaticiUrunId { get; set; }

        public virtual TblDigerSaticiUrun? DigerSaticiUrun { get; set; }
    }
}
