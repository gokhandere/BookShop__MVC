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
    
    public partial class Actor
    {
        public Actor()
        {
            this.DVD_Actor = new HashSet<DVD_Actor>();
        }
    
        public int id { get; set; }
        public string ActorName { get; set; }
    
        public virtual ICollection<DVD_Actor> DVD_Actor { get; set; }
    }
}
