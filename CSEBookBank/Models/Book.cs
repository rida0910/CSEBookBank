//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSEBookBank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string IssuedTo { get; set; }
        public Nullable<System.DateTime> IssuedDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}
