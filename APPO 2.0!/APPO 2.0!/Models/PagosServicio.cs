using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class PagosServicio
    {
        public int NroComprobante { get; set; }
        public int IdServicio { get; set; }
        public string CvuPago { get; set; }
        public int NroFactura { get; set; }
        public string NombreFactura { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public virtual Cuenta CvuPagoNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
