//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class DVDSales
    {
        public int id { get; set; }
        public string UserID { get; set; }
        public Nullable<int> DVDID { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual DVD DVD { get; set; }
    }
}