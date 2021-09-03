using System;
using System.Collections.Generic;

#nullable disable

namespace APPO.Models
{
    public partial class ComprasMoneda
    {
        public int NroCompCompra { get; set; }
        public string NombreCripto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string CvuCompra { get; set; }

        public virtual Cuenta CvuCompraNavigation { get; set; }
    }
}
