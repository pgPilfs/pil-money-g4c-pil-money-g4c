using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Models.ViewModels
{
    public class ActividadViewModel
    {
        public List<decimal> Monto { get; set; }
        public List<decimal> MontoInversion { get; set; }
        public List<string> NombreFactura { get; set; }
        public List<string> CvuDestino { get; set; }

    }
}
