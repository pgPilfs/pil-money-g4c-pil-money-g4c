using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Core.DTO
{
    public class IngresosDineroDTO
    {
        public int IdDeposito { get; set; }
        public string NombreDeposito { get; set; }
        public string CvuDeposito { get; set; }
        public string NroTarjeta { get; set; }
        public DateTime? FechaVenc { get; set; }
        public int? CodSeguridad { get; set; }
        public string NombreTitular { get; set; }
    }
}
