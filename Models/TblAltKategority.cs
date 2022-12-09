using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblAltKategority
    {
        public int AltKategoriId { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? ParentId { get; set; }
    }
}
