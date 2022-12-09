using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblDigerSatici
    {
        public TblDigerSatici()
        {
            TblDigerUrunSaticiNms = new HashSet<TblDigerUrunSaticiNm>();
        }

        public int DigerSaticiId { get; set; }
        public int? MerchantId { get; set; }
        public string? MerchantName { get; set; }
        public string? Sehir { get; set; }
        public string? MerchantPageUrl { get; set; }
        public string? MerchantCity { get; set; }
        public string? MerchantCountry { get; set; }
        public string? DispatchTime { get; set; }
        public string? BuyBoxOrder { get; set; }
        public string? Quantity { get; set; }
        public string? MerchantVariantUrl { get; set; }
        public double? LifeTimeRating { get; set; }
        public string? IsFulfilledByHb { get; set; }

        public virtual ICollection<TblDigerUrunSaticiNm> TblDigerUrunSaticiNms { get; set; }
    }
}
