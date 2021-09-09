using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_.Core.Entidades
{
    public partial class Transferencia
    {
        public int NroTransferencia { get; set; }
        public string CvuOrigen { get; set; }
        public string CvuDestino { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; }

        public virtual Cuenta CvuDestinoNavigation { get; set; }
        public virtual Cuenta CvuOrigenNavigation { get; set; }
    }
}
