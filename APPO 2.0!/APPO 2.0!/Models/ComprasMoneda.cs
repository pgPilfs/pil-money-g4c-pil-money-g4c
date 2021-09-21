using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class ComprasMoneda
    {
        public int NroCompCompra { get; set; }
        public string NombreCripto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public long CvuCompra { get; set; }

        public virtual Cuenta CvuCompraNavigation { get; set; }
    }
}
