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
    
    public partial class Category
    {
        public Category()
        {
            this.Book = new HashSet<Book>();
            this.DVD = new HashSet<DVD>();
            this.MusicCD = new HashSet<MusicCD>();
        }
    
        public int id { get; set; }
        public string ProductType { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<Book> Book { get; set; }
        public virtual ICollection<DVD> DVD { get; set; }
        public virtual ICollection<MusicCD> MusicCD { get; set; }
    }
}