//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int orderid { get; set; }
        public System.DateTime order_date { get; set; }
        public System.TimeSpan order_time { get; set; }
        public decimal amount { get; set; }
        public string status { get; set; }
    }
}