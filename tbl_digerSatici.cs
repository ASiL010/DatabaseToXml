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
    
    public partial class tbl_digerSatici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_digerSatici()
        {
            this.tbl_digerUrunSaticiNm = new HashSet<tbl_digerUrunSaticiNm>();
        }
    
        public int digerSatici_id { get; set; }
        public Nullable<int> merchantId { get; set; }
        public string merchantName { get; set; }
        public string sehir { get; set; }
        public string merchantPageUrl { get; set; }
        public string merchantCity { get; set; }
        public string merchantCountry { get; set; }
        public string dispatchTime { get; set; }
        public string buyBoxOrder { get; set; }
        public string quantity { get; set; }
        public string merchantVariantUrl { get; set; }
        public Nullable<double> lifeTimeRating { get; set; }
        public string isFulfilledByHB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_digerUrunSaticiNm> tbl_digerUrunSaticiNm { get; set; }
    }
}