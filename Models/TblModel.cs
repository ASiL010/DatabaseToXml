using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblModel
    {
        public int ModelId { get; set; }
        public string? Model { get; set; }
        public int? MarkaId { get; set; }

        public virtual TblMarka? Marka { get; set; }
    }
}
