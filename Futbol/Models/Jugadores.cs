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
    
    public partial class Jugadores
    {
        public decimal ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public Nullable<System.DateTime> F_NACIMIENTO { get; set; }
        public string POSICION { get; set; }
        public Nullable<decimal> EQUIPO { get; set; }
        public string IMAGEN { get; set; }
    
        public virtual Equipos EQUIPOS { get; set; }
    }
}
