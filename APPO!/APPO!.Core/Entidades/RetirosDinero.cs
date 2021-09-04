using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_.Core.Entidades
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
