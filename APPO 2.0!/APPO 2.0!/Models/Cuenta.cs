using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            ComprasMoneda = new HashSet<ComprasMoneda>();
            IngresosDineros = new HashSet<IngresosDinero>();
            Inversiones = new HashSet<Inversione>();
            PagosServicios = new HashSet<PagosServicio>();
            RetirosDineros = new HashSet<RetirosDinero>();
            TransferenciaCvuDestinoNavigations = new HashSet<Transferencia>();
            TransferenciaCvuOrigenNavigations = new HashSet<Transferencia>();
            VentasMoneda = new HashSet<VentasMoneda>();
        }

        public long Cvu { get; set; }
        public string Alias { get; set; }
        public int IdTipoCuenta { get; set; }
        public decimal SaldoActual { get; set; }
        public int IdUsuario { get; set; }

        public virtual TiposCuenta IdTipoCuentaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ComprasMoneda> ComprasMoneda { get; set; }
        public virtual ICollection<IngresosDinero> IngresosDineros { get; set; }
        public virtual ICollection<Inversione> Inversiones { get; set; }
        public virtual ICollection<PagosServicio> PagosServicios { get; set; }
        public virtual ICollection<RetirosDinero> RetirosDineros { get; set; }
        public virtual ICollection<Transferencia> TransferenciaCvuDestinoNavigations { get; set; }
        public virtual ICollection<Transferencia> TransferenciaCvuOrigenNavigations { get; set; }
        public virtual ICollection<VentasMoneda> VentasMoneda { get; set; }
    }
}
