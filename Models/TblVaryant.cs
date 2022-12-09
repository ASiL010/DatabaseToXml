using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblVaryant
    {
        public int VaryantId { get; set; }
        public string? ItemId { get; set; }
        public string? PropertiesValue { get; set; }
        public string? OrderNumber { get; set; }
    }
}
