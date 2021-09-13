using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class RetirosDinero
    {
        public int IdRetiro { get; set; }
        public string CvuRetiro { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public virtual Cuenta CvuRetiroNavigation { get; set; }
    }
}
