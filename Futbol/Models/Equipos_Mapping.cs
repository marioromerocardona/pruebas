//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Futbol.Models
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Equipos_Mapping : EntityTypeConfiguration<Equipos>
    {
        public Equipos_Mapping()
        {					
    		this.HasKey(t => t.ID);		
    		this.ToTable("EQUIPOS", "PROTOCOLO");
    		this.Property(t => t.ID).HasColumnName("ID");
    		this.Property(t => t.NOMBRE).HasColumnName("NOMBRE").IsUnicode(false).HasMaxLength(200);
    		this.Property(t => t.ORIGEN).HasColumnName("ORIGEN").IsUnicode(false).HasMaxLength(200);
    		this.Property(t => t.PRESUPUESTO).HasColumnName("PRESUPUESTO");
    		this.Property(t => t.ABONADOS).HasColumnName("ABONADOS");
    		this.Property(t => t.FUNDACION).HasColumnName("FUNDACION");
    	}
    }
}
