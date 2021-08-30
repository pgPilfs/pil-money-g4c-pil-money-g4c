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
    
    public partial class Cuentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas()
        {
            this.ComprasMonedas = new HashSet<ComprasMonedas>();
            this.IngresosDinero = new HashSet<IngresosDinero>();
            this.Inversiones = new HashSet<Inversiones>();
            this.PagosServicio = new HashSet<PagosServicio>();
            this.RetirosDinero = new HashSet<RetirosDinero>();
            this.Transferencias = new HashSet<Transferencias>();
            this.Transferencias1 = new HashSet<Transferencias>();
            this.VentasMonedas = new HashSet<VentasMonedas>();
        }
    
        public string CVU { get; set; }
        public string alias { get; set; }
        public int id_tipo_cuenta { get; set; }
        public decimal saldo_actual { get; set; }
        public int dni_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprasMonedas> ComprasMonedas { get; set; }
        public virtual TiposCuentas TiposCuentas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresosDinero> IngresosDinero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inversiones> Inversiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagosServicio> PagosServicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetirosDinero> RetirosDinero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencias> Transferencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencias> Transferencias1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VentasMonedas> VentasMonedas { get; set; }
    }
}
