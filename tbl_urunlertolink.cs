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
    
    public partial class tbl_urunlertolink
    {
        public int id { get; set; }
        public string SaticiStokKodu { get; set; }
        public string SKU { get; set; }
        public string urunAdi { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string EnAltKategori { get; set; }
        public string AnaKategori { get; set; }
        public string EnTemelKategori { get; set; }
        public string Marka { get; set; }
        public string resimyol { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<bool> kayitdurum { get; set; }
    }
}