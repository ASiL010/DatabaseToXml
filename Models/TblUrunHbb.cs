using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblUrunHbb
    {
        public int UrunId { get; set; }
        public string? HepsiburadaSku { get; set; }
        public string? MerchantSku { get; set; }
        public string? Price { get; set; }
        public string? AvailableStock { get; set; }
        public string? DispatchTime { get; set; }
        public string? CargoCompany1 { get; set; }
        public string? CargoCompany2 { get; set; }
        public string? CargoCompany3 { get; set; }
        public string? ShippingAddressLabel { get; set; }
        public string? ShippingProfileName { get; set; }
        public string? ClaimAddressLabel { get; set; }
        public string? PricingFinalPrice { get; set; }
        public string? PricingStartDate { get; set; }
        public string? PricingEndDate { get; set; }
        public string? PricingDebtor { get; set; }
        public string? PricingAmount { get; set; }
        public string? MaximumPurchasableQuantity { get; set; }
        public string? IsSalable { get; set; }
        public string? CustomizableProperties { get; set; }
        public string? IsSuspended { get; set; }
        public string? IsLocked { get; set; }
        public string? LockReasons { get; set; }
        public string? IsFrozen { get; set; }
        public string? CommissionRate { get; set; }
        public string? PriceIncreaseDisabled { get; set; }
        public string? PriceDecreaseDisabled { get; set; }
        public string? StockDecreaseDisabled { get; set; }
    }
}
