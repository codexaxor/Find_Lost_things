//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindLostThings.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string userType { get; set; }
        public int userId { get; set; }
        public int postalCode { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
