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
    
    public partial class Equipos
    {
        public Equipos()
        {
            this.CLASIFICACIONs = new HashSet<Clasificacion>();
            this.JUGADORES = new HashSet<Jugadores>();
        }
    
        public decimal ID { get; set; }
        public string NOMBRE { get; set; }
        public string ORIGEN { get; set; }
        public Nullable<decimal> PRESUPUESTO { get; set; }
        public Nullable<decimal> ABONADOS { get; set; }
        public Nullable<System.DateTime> FUNDACION { get; set; }
    
        public virtual ICollection<Clasificacion> CLASIFICACIONs { get; set; }
        public virtual ICollection<Jugadores> JUGADORES { get; set; }
    }
}
