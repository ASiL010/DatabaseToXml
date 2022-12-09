using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class HbKayitBazliMuhasebeServisi
    {
        public string TransactionType { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public string? PackageNumber { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string InvoiceNumber { get; set; } = null!;
        public string OrderItemNumber { get; set; } = null!;
        public string? Quantity { get; set; }
        public string? AmountValue { get; set; }
        public string? AmountCurrencyCode { get; set; }
        public string? TaxAmountValue { get; set; }
        public string? TaxAmountCurrencyCode { get; set; }
        public string? NetAmountValue { get; set; }
        public string? NetAmountCurrencyCode { get; set; }
        public string? OrderDate { get; set; }
        public string? InvoiceDate { get; set; }
        public string? DueDate { get; set; }
        public string? PaymentDate { get; set; }
        public string InvoiceExplanation { get; set; } = null!;
        public string? MerchantId { get; set; }
        public string? IsInvoice { get; set; }
        public string? IsIncome { get; set; }
        public string? TransactionTypeCategory { get; set; }
        public string? ProductName { get; set; }
    }
}
