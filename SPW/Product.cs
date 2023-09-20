//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPW
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.DetailProductTrxes = new HashSet<DetailProductTrx>();
            this.DetailStocks = new HashSet<DetailStock>();
        }
    
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Stock { get; set; }
        public int StatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailProductTrx> DetailProductTrxes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailStock> DetailStocks { get; set; }
        public virtual Status Status { get; set; }
    }
}
