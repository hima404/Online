//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onllineShopping
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int orderID { get; set; }
        public Nullable<int> users_ID { get; set; }
        public Nullable<int> products_ID { get; set; }
        public Nullable<int> quantity { get; set; }
        public string productName { get; set; }
    
        public virtual product product { get; set; }
        public virtual user user { get; set; }
    }
}
