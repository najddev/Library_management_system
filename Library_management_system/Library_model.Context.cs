﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class project_libraryEntities : DbContext
    {
        public project_libraryEntities()
            : base("name=project_libraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Book> Book { get; set; }
        public DbSet<Book_borrowed> Book_borrowed { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
        public DbSet<fines_category> fines_category { get; set; }
        public DbSet<Libarian> Libarian { get; set; }
        public DbSet<pay_fines> pay_fines { get; set; }
        public DbSet<StateBook> StateBook { get; set; }
    }
}
