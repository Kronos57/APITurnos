//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbConection
{
    using System;
    
    public partial class spGenerarTurnos_Result
    {
        public int id_turno { get; set; }
        public int id_servicio { get; set; }
        public System.DateTime fecha_turno { get; set; }
        public System.TimeSpan hora_inicio { get; set; }
        public System.TimeSpan hora_fin { get; set; }
        public string Estado { get; set; }
    }
}