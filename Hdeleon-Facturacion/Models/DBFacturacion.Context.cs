﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hdeleon_Facturacion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class facturacionEntities : DbContext
    {
        public facturacionEntities()
            : base("name=facturacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cstate> cstate { get; set; }
        public DbSet<cstate_invoice> cstate_invoice { get; set; }
        public DbSet<product_tax> product_tax { get; set; }
        public DbSet<cmunicipio> cmunicipio { get; set; }
        public DbSet<destado> destado { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<invoice> invoice { get; set; }
        public DbSet<tax> tax { get; set; }
        public DbSet<ctype_invoice> ctype_invoice { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<customer> customer { get; set; }
    }
}