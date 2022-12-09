using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblHizliEkleHb
    {
        public int HueId { get; set; }
        public string? ProductName { get; set; }
        public string? MerchantSku { get; set; }
        public string? Barcode { get; set; }
        public string? Price { get; set; }
        public string? Stock { get; set; }
    }
}
