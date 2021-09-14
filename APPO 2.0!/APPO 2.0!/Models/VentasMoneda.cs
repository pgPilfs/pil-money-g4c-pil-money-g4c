using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
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
