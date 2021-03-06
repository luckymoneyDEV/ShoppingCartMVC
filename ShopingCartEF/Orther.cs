//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopingCartEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orther
    {
        public Orther()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int OrtherID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> DateOrdered { get; set; }
        public Nullable<System.DateTime> DateRicived { get; set; }
        public string ShippingMethod { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public Nullable<double> Amout { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual PaymenMethod PaymenMethod { get; set; }
    }
}
