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
    
    public partial class tbl_urunHbb
    {
        public int urun_id { get; set; }
        public string HepsiburadaSku { get; set; }
        public string MerchantSku { get; set; }
        public string Price { get; set; }
        public string AvailableStock { get; set; }
        public string DispatchTime { get; set; }
        public string CargoCompany1 { get; set; }
        public string CargoCompany2 { get; set; }
        public string CargoCompany3 { get; set; }
        public string ShippingAddressLabel { get; set; }
        public string shippingProfileName { get; set; }
        public string ClaimAddressLabel { get; set; }
        public string Pricing_FinalPrice { get; set; }
        public string Pricing_StartDate { get; set; }
        public string Pricing_EndDate { get; set; }
        public string Pricing_Debtor { get; set; }
        public string Pricing_Amount { get; set; }
        public string MaximumPurchasableQuantity { get; set; }
        public string IsSalable { get; set; }
        public string CustomizableProperties { get; set; }
        public string IsSuspended { get; set; }
        public string IsLocked { get; set; }
        public string LockReasons { get; set; }
        public string IsFrozen { get; set; }
        public string CommissionRate { get; set; }
        public string priceIncreaseDisabled { get; set; }
        public string priceDecreaseDisabled { get; set; }
        public string stockDecreaseDisabled { get; set; }
    }
}
