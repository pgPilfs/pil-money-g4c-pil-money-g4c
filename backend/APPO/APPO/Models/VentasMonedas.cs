//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VentasMonedas
    {
        public int nro_comp_ventas { get; set; }
        public decimal monto { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public string CVU_venta { get; set; }
    
        public virtual Cuentas Cuentas { get; set; }
    }
}
