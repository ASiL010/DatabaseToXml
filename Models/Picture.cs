using System;
using System.Collections.Generic;

namespace DatabaseToXml.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Path { get; set; }
        public string? Path2 { get; set; }
        public string? Path3 { get; set; }
        public string? Path4 { get; set; }
    }
}
