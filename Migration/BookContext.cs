﻿namespace Migration
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookContext : DbContext
    {

        public BookContext()
            : base("name=BookContext")
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Delivery> Deliveries {get;set;}
    }
       

 
}