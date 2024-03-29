﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1573
namespace Futbol.Models
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        static Entities()
    	{ 
    		Database.SetInitializer<Entities>(null);
    	}
    	
    	public Entities() : base("name=Entities")
        {
        }
    	
    	public Entities(string nameOrConnectionString) : base(nameOrConnectionString)
    	{	
    	}
    
    	public Entities(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
    	{
    	}
    
    	public Entities(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
    	{
    	}
    
    	public Entities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
    	{
    	}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    		modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
    		modelBuilder.Configurations.Add(new Clasificacion_Mapping());
    		modelBuilder.Configurations.Add(new Equipos_Mapping());
    		modelBuilder.Configurations.Add(new Jugadores_Mapping());
        }
    	
        public DbSet<Clasificacion> Clasificacion { get; set; }
        public DbSet<Equipos> Equipos { get; set; }
        public DbSet<Jugadores> Jugadores { get; set; }
    }
}
