using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class IptalEdilenSiparisler
    {
        public int Id { get; set; }
        public string? LineItemId { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? CancelDate { get; set; }
        public string? CancelledBy { get; set; }
        public string? CancelReasonCode { get; set; }
        public string? MerchantId { get; set; }
        public string? Quantity { get; set; }
        public string? Sku { get; set; }
        public string? MerchantSku { get; set; }
    }
}
