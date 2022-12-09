using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblOrtakSipari
    {
        public int PaketId { get; set; }
        public string? Sku { get; set; }
        public string? SiparisNo { get; set; }
        public string? TelefonNo { get; set; }
        public string? MAd { get; set; }
        public string? Tad { get; set; }
        public string? FullAdres { get; set; }
        public string? Ozellikler1 { get; set; }
        public string? KargoSirketi { get; set; }
        public string? Statu { get; set; }
        public string? SiparisTarihi { get; set; }
        public string? SonGuncellemeTarihi { get; set; }
        public string? PazarYeri { get; set; }
        public string? Ozellikler2 { get; set; }
        public string? Adet { get; set; }
        public string? Lineid { get; set; }
    }
}
