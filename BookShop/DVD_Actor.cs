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
    
    public partial class DVD_Actor
    {
        public int id { get; set; }
        public Nullable<int> DVDID { get; set; }
        public Nullable<int> ActorID { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual DVD DVD { get; set; }
    }
}