using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_.Core.Entidades
{
    public partial class VentasMoneda
    {
        public int NroCompVentas { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string CvuVenta { get; set; }

        public virtual Cuenta CvuVentaNavigation { get; set; }
    }
}
