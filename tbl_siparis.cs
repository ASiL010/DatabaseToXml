//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseToXml
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_siparis
    {
        public int siparis_id { get; set; }
        public string totalCount { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string pageCount { get; set; }
        public string items_dueDate { get; set; }
        public string items_lastStatusUpdateDate { get; set; }
        public string items_id { get; set; }
        public string items_sku { get; set; }
        public string items_orderId { get; set; }
        public string items_orderNumber { get; set; }
        public Nullable<System.DateTime> items_orderDate { get; set; }
        public string items_quantity { get; set; }
        public string items_merchantId { get; set; }
        public string items_totalPrice_currency { get; set; }
        public string items_totalPrice_amount { get; set; }
        public string items_unitPrice_currency { get; set; }
        public string items_unitPrice_amount { get; set; }
        public string items_vat { get; set; }
        public string items_vatRate { get; set; }
        public string items_customerName { get; set; }
        public string items_status { get; set; }
        public string items_shippingAddress { get; set; }
        public string items_invoice { get; set; }
        public string items_invoice_turkishIdentityNumber { get; set; }
        public string items_invoice_taxNumber { get; set; }
        public string items_invoice_taxOffice { get; set; }
        public string items_invoice_address { get; set; }
        public string items_invoice_address_addressId { get; set; }
        public string items_invoice_address_address { get; set; }
        public string items_invoice_address_name { get; set; }
        public string items_invoice_address_email { get; set; }
        public string items_invoice_address_countryCode { get; set; }
        public string items_invoice_address_phoneNumber { get; set; }
        public string items_invoice_address_alternatePhoneNumber { get; set; }
        public string items_invoice_address_district { get; set; }
        public string items_invoice_address_city { get; set; }
        public string items_invoice_address_town { get; set; }
        public string items_sapNumber { get; set; }
        public string items_dispatchTime { get; set; }
        public string items_commission { get; set; }
        public string items_commission_currency { get; set; }
        public string items_commission_amount { get; set; }
        public string items_paymentTermInDays { get; set; }
        public string items_commissionType { get; set; }
        public string items_cargoCompanyModel_id { get; set; }
        public string items_cargoCompanyModel_name { get; set; }
        public string items_cargoCompanyModel_shortName { get; set; }
        public string items_cargoCompanyModel_logoUrl { get; set; }
        public string items_cargoCompanyModel_trackingUrl { get; set; }
        public string items_cargoCompany { get; set; }
        public string items_customizedText01 { get; set; }
        public string items_customizedText02 { get; set; }
        public string items_customizedText03 { get; set; }
        public string items_customizedText04 { get; set; }
        public string items_customizedTextX { get; set; }
        public string items_creditCardHolderName { get; set; }
        public string items_isCustomized { get; set; }
        public string items_canCreatePackage { get; set; }
        public string items_isCancellable { get; set; }
        public string items_isCancellableByHbAdmin { get; set; }
        public string items_deliveryType { get; set; }
        public string items_deliveryOptionId { get; set; }
        public string items_slot { get; set; }
        public string items_pickUpTime { get; set; }
        public string items_purchasePrice { get; set; }
        public string properties_value { get; set; }
        public string magaza { get; set; }
        public Nullable<bool> xmlYapildi { get; set; }
    }
}
