using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblBuybox
    {
        public int BuyboxId { get; set; }
        public int? BizimSira { get; set; }
        public string? ÜrünAd { get; set; }
        public decimal? BizimFiyat { get; set; }
        public decimal? MinFiyat { get; set; }
        public decimal? MaxFiyat { get; set; }
        public string? Sku { get; set; }
        public string? Rank { get; set; }
        public string? MerchantName { get; set; }
        public string? Price { get; set; }
        public string? DispatchTime { get; set; }
        public string? MerchantRating { get; set; }
        public string? Onceki { get; set; }
        public string? Sonraki { get; set; }
        public decimal? Öneri { get; set; }
        public bool? Otomanuel { get; set; }
        public decimal? Fark { get; set; }
        public decimal? Endusukfiyat { get; set; }
        public decimal? Baslangıcfiyat { get; set; }
        public bool? Farkdurum { get; set; }
        public bool? Durum { get; set; }
        public decimal? GuncelFiyat { get; set; }
        public bool? Elleotomatik { get; set; }
        public int? Islemsayisi { get; set; }
        public decimal? Sonfiyat { get; set; }
        public string? Marka { get; set; }
    }
}
