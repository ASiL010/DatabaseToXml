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
    
    public partial class tbl_picture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_picture()
        {
            this.tbl_product = new HashSet<tbl_product>();
        }
    
        public int resim_id { get; set; }
        public string url_1 { get; set; }
        public string url_2 { get; set; }
        public string url_3 { get; set; }
        public string url_4 { get; set; }
        public string url_5 { get; set; }
        public string url_6 { get; set; }
        public string url_7 { get; set; }
        public string url_8 { get; set; }
        public string url_9 { get; set; }
        public string url_10 { get; set; }
        public Nullable<int> urun_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_product> tbl_product { get; set; }
    }
}
