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
    
    public partial class DetailProductTrx
    {
        public int DetailId { get; set; }
        public string TrxId { get; set; }
        public string ProductId { get; set; }
        public int Qty { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
    
        public virtual HeaderTrx HeaderTrx { get; set; }
        public virtual Product Product { get; set; }
    }
}
