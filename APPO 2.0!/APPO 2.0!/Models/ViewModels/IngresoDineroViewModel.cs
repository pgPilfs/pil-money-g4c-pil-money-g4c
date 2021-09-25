using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Models.ViewModels
{
    public class IngresoDineroViewModel
    {
        public string CvuDeposito { get; set; }
        public string NroTarjeta { get; set; }
        public DateTime FechaVenc { get; set; }
        public int CodSeguridad { get; set; }
        public string NombreTitular { get; set; }
        public decimal Monto { get; set; }
    }
}
