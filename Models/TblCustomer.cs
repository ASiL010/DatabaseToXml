using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblCustomer
    {
        public int MusteriId { get; set; }
        public string? MAd { get; set; }
        public string? MSoyad { get; set; }
        public string? Tel { get; set; }
        public string? Adres { get; set; }
    }
}
