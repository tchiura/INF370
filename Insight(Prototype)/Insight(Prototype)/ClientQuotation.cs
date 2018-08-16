//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insight_Prototype_
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientQuotation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientQuotation()
        {
            this.ProductClientQuotationLines = new HashSet<ProductClientQuotationLine>();
            this.Returns = new HashSet<Return>();
            this.JobTypes = new HashSet<JobType>();
        }
    
        public int ClientQuotationID { get; set; }
        public System.DateTime ClientQuotationDate { get; set; }
        public int ProjectRequestID { get; set; }
        public int ClientQuotationStatusID { get; set; }
    
        public virtual ClientQuotationStatu ClientQuotationStatu { get; set; }
        public virtual ProjectRequest ProjectRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductClientQuotationLine> ProductClientQuotationLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Return> Returns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobType> JobTypes { get; set; }
    }
}
