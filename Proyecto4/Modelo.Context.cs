﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD : DbContext
    {
        public BD()
            : base("name=BD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblcaja> tblcaja { get; set; }
        public DbSet<tblcomisionespagadas> tblcomisionespagadas { get; set; }
        public DbSet<tblcomisionvendedor> tblcomisionvendedor { get; set; }
        public DbSet<tblhistorialcompra> tblhistorialcompra { get; set; }
        public DbSet<tblhistorialventa> tblhistorialventa { get; set; }
        public DbSet<tblproducto> tblproducto { get; set; }
        public DbSet<tblusuario> tblusuario { get; set; }
    }
}