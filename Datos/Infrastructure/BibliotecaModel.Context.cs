﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BibliotecaEntities : DbContext
    {
        public BibliotecaEntities()
            : base("name=BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Libro> Libroes { get; set; }
        public virtual DbSet<LibrosUnidade> LibrosUnidades { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
    
        public virtual ObjectResult<ObtenerLibrosConUnidades_Result> ObtenerLibrosConUnidades()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerLibrosConUnidades_Result>("ObtenerLibrosConUnidades");
        }
    }
}
