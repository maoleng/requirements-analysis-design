//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winform
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProduct
    {
        public long order_id { get; set; }
        public long product_id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public double discount_price { get; set; }
        public double original_price { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
