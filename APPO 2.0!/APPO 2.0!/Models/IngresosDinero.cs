using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class IngresosDinero
    {
        public int IdDeposito { get; set; }
        public string NombreDeposito { get; set; }
        
        
        public long CvuDeposito { get; set; }
        public string NroTarjeta { get; set; }
        public DateTime FechaVenc { get; set; }
        public int CodSeguridad { get; set; }
        public string NombreTitular { get; set; }
        public decimal Monto { get; set; }

        public virtual Cuenta CvuDepositoNavigation { get; set; }
    }
}
