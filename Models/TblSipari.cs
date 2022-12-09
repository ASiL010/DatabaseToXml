using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblSipari
    {
        public int SiparisId { get; set; }
        public string? TotalCount { get; set; }
        public string? Limit { get; set; }
        public string? Offset { get; set; }
        public string? PageCount { get; set; }
        public string? ItemsDueDate { get; set; }
        public string? ItemsLastStatusUpdateDate { get; set; }
        public string? ItemsId { get; set; }
        public string? ItemsSku { get; set; }
        public string? ItemsOrderId { get; set; }
        public string? ItemsOrderNumber { get; set; }
        public DateTime? ItemsOrderDate { get; set; }
        public string? ItemsQuantity { get; set; }
        public string? ItemsMerchantId { get; set; }
        public string? ItemsTotalPriceCurrency { get; set; }
        public string? ItemsTotalPriceAmount { get; set; }
        public string? ItemsUnitPriceCurrency { get; set; }
        public string? ItemsUnitPriceAmount { get; set; }
        public string? ItemsVat { get; set; }
        public string? ItemsVatRate { get; set; }
        public string? ItemsCustomerName { get; set; }
        public string? ItemsStatus { get; set; }
        public string? ItemsShippingAddress { get; set; }
        public string? ItemsInvoice { get; set; }
        public string? ItemsInvoiceTurkishIdentityNumber { get; set; }
        public string? ItemsInvoiceTaxNumber { get; set; }
        public string? ItemsInvoiceTaxOffice { get; set; }
        public string? ItemsInvoiceAddress { get; set; }
        public string? ItemsInvoiceAddressAddressId { get; set; }
        public string? ItemsInvoiceAddressAddress { get; set; }
        public string? ItemsInvoiceAddressName { get; set; }
        public string? ItemsInvoiceAddressEmail { get; set; }
        public string? ItemsInvoiceAddressCountryCode { get; set; }
        public string? ItemsInvoiceAddressPhoneNumber { get; set; }
        public string? ItemsInvoiceAddressAlternatePhoneNumber { get; set; }
        public string? ItemsInvoiceAddressDistrict { get; set; }
        public string? ItemsInvoiceAddressCity { get; set; }
        public string? ItemsInvoiceAddressTown { get; set; }
        public string? ItemsSapNumber { get; set; }
        public string? ItemsDispatchTime { get; set; }
        public string? ItemsCommission { get; set; }
        public string? ItemsCommissionCurrency { get; set; }
        public string? ItemsCommissionAmount { get; set; }
        public string? ItemsPaymentTermInDays { get; set; }
        public string? ItemsCommissionType { get; set; }
        public string? ItemsCargoCompanyModelId { get; set; }
        public string? ItemsCargoCompanyModelName { get; set; }
        public string? ItemsCargoCompanyModelShortName { get; set; }
        public string? ItemsCargoCompanyModelLogoUrl { get; set; }
        public string? ItemsCargoCompanyModelTrackingUrl { get; set; }
        public string? ItemsCargoCompany { get; set; }
        public string? ItemsCustomizedText01 { get; set; }
        public string? ItemsCustomizedText02 { get; set; }
        public string? ItemsCustomizedText03 { get; set; }
        public string? ItemsCustomizedText04 { get; set; }
        public string? ItemsCustomizedTextX { get; set; }
        public string? ItemsCreditCardHolderName { get; set; }
        public string? ItemsIsCustomized { get; set; }
        public string? ItemsCanCreatePackage { get; set; }
        public string? ItemsIsCancellable { get; set; }
        public string? ItemsIsCancellableByHbAdmin { get; set; }
        public string? ItemsDeliveryType { get; set; }
        public string? ItemsDeliveryOptionId { get; set; }
        public string? ItemsSlot { get; set; }
        public string? ItemsPickUpTime { get; set; }
        public string? ItemsPurchasePrice { get; set; }
        public string? PropertiesValue { get; set; }
        public string? Magaza { get; set; }
        public bool? Xml { get; set; }
        public DateTime? PaketlemeTarihi { get; set; }
        public DateTime? KargolamaTarihi { get; set; }
        public DateTime? TeslimedilmeTarihi { get; set; }
        public bool? BasılmaDurum { get; set; }
    }
}
