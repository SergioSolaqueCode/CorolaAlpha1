﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CorolaAlpha1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class corolaalphaEntities : DbContext
    {
        public corolaalphaEntities()
            : base("name=corolaalphaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<especies> especies { get; set; }
        public virtual DbSet<registroentrada> registroentrada { get; set; }
        public virtual DbSet<registrosalida> registrosalida { get; set; }
        public virtual DbSet<Reporte> Reporte { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuariorol> usuariorol { get; set; }
    }
}
