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
    
    public partial class Musician
    {
        public Musician()
        {
            this.MusicCD = new HashSet<MusicCD>();
        }
    
        public int id { get; set; }
        public string MusicianName { get; set; }
    
        public virtual ICollection<MusicCD> MusicCD { get; set; }
    }
}
