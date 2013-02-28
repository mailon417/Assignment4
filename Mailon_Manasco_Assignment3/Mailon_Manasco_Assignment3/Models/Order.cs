//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mailon_Manasco_Assignment3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
