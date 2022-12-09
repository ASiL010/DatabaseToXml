using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblIptalEdilenTy
    {
        public int IptalEdilenSiparislerId { get; set; }
        public string? OrderNumber { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? Id { get; set; }
        public string? CargoTrackingNumber { get; set; }
        public string? CargoProviderName { get; set; }
        public string? OrderDate { get; set; }
        public string? Status { get; set; }
        public string? TotalPrice { get; set; }
    }
}
