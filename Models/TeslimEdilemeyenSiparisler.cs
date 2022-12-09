using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TeslimEdilemeyenSiparisler
    {
        public int Pid { get; set; }
        public string? Barcode { get; set; }
        public string? PackageNumber { get; set; }
        public string? OrderNumber { get; set; }
        public string? MerchantId { get; set; }
        public DateTime? UndeliveredDate { get; set; }
        public string? UndeliveredReason { get; set; }
        public string? Lineitemid { get; set; }
    }
}
