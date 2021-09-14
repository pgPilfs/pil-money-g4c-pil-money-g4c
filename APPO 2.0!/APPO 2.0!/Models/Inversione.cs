using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Inversione
    {
        public int IdInversion { get; set; }
        public decimal MontoInversion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string CvuInversion { get; set; }

        public virtual Cuenta CvuInversionNavigation { get; set; }
    }
}
