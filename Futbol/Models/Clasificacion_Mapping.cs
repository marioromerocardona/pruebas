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
    
    internal partial class Clasificacion_Mapping : EntityTypeConfiguration<Clasificacion>
    {
        public Clasificacion_Mapping()
        {					
    		this.HasKey(t => t.ID);		
    		this.ToTable("CLASIFICACION", "PROTOCOLO");
    		this.Property(t => t.ID).HasColumnName("ID");
    		this.Property(t => t.POSICION).HasColumnName("POSICION");
    		this.Property(t => t.EQUIPO).HasColumnName("EQUIPO");
    		this.Property(t => t.GOLES).HasColumnName("GOLES");
    		this.Property(t => t.PUNTOS).HasColumnName("PUNTOS");
    		this.HasOptional(t => t.EQUIPOS).WithMany(t => t.CLASIFICACIONs).HasForeignKey(d => d.EQUIPO);
    	}
    }
}
