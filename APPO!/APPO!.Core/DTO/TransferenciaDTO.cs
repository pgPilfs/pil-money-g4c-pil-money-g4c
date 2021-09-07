using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Core.DTO
{
    public class TransferenciaDTO
    {
        public int NroTransferencia { get; set; }
        public string CvuOrigen { get; set; }
        public string CvuDestino { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; }
    }
}
