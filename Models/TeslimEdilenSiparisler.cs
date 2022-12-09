using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TeslimEdilenSiparisler
    {
        public int Pid { get; set; }
        public string? LineItemId { get; set; }
        public string? Barcode { get; set; }
        public string? PackageNumber { get; set; }
        public string? OrderNumber { get; set; }
        public string? MerchantId { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
