//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_management_system
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrower
    {
        public Borrower()
        {
            this.Book_borrowed = new HashSet<Book_borrowed>();
        }
    
        public int Borrower_ID { get; set; }
        public string Br_UN { get; set; }
        public string Br_pass { get; set; }
        public Nullable<bool> block_user { get; set; }
        public Nullable<System.DateTime> block_date { get; set; }
        public Nullable<bool> notAllowed_user { get; set; }
        public Nullable<int> date_count { get; set; }
    
        public virtual ICollection<Book_borrowed> Book_borrowed { get; set; }
    }
}
