using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class TblKategorilerHb
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? DisplayName { get; set; }
        public decimal? ParentCategoryId { get; set; }
        public string? Paths { get; set; }
        public string? Leaf { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public int? SortId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Available { get; set; }
        public string? ProductTypesName { get; set; }
        public decimal? ProductTypesTypeId { get; set; }
    }
}
