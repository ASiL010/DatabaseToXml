using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TyOrder
    {
        public string? ShipmentAdressFullName { get; set; }
        public string? ShipmentAdressFullAdress { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string? GrossAmount { get; set; }
        public string? TotalDiscount { get; set; }
        public string? TotalTyDiscount { get; set; }
        public string? InvoiceAdressFullName { get; set; }
        public string? InvoiceAdressFullAdress { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerId { get; set; }
        public string? CargoTrackingNumber { get; set; }
        public string? CargoTrackingLink { get; set; }
        public string? CargoSenderNumber { get; set; }
        public string? CargoProviderName { get; set; }
        public string? Quantity { get; set; }
        public string? SalesCampaignId { get; set; }
        public string? ProductSize { get; set; }
        public string? MerchantSku { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? MerchantId { get; set; }
        public string? Amount { get; set; }
        public string? Discount { get; set; }
        public string? TyDiscount { get; set; }
        public string? CurrencyCode { get; set; }
        public string? ProductColor { get; set; }
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? VatBaseAmount { get; set; }
        public string? Barcode { get; set; }
        public string? OrderLineItemStatusName { get; set; }
        public string? Price { get; set; }
        public string? OrderDate { get; set; }
        public string? TcIdentityNumber { get; set; }
        public string? ShipmentPackageStatus { get; set; }
        public string? Status { get; set; }
        public string? DeliveryType { get; set; }
        public string? TimeSlotId { get; set; }
        public string? ScheduleDeliveryStoreId { get; set; }
        public string? EstimatedDeliveryStartDate { get; set; }
        public string? EstimatedDeliveryEndDate { get; set; }
        public string? TotalPrice { get; set; }
        public string? DeliveryAddressType { get; set; }
        public string? AgreedDeliveryDate { get; set; }
        public string? AgreedDeliveryDateExtendible { get; set; }
        public string? ExtendedAgreedDeliveryDate { get; set; }
        public string? AgreedDeliveryExtensionStartDate { get; set; }
        public string? AgreedDeliveryExtensionEndDate { get; set; }
        public string? FastDelivery { get; set; }
        public string? FastDeliveryType { get; set; }
        public string? OriginShipmentDate { get; set; }
        public string LastModifiedDate { get; set; } = null!;
        public string? Commercial { get; set; }
        public string? DeliveredByService { get; set; }
    }
}
