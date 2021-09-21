using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Transferencia
    {
        public int NroTransferencia { get; set; }
        public long CvuOrigen { get; set; }
        public long CvuDestino { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; }

        public virtual Cuenta CvuDestinoNavigation { get; set; }
        public virtual Cuenta CvuOrigenNavigation { get; set; }
    }
}
