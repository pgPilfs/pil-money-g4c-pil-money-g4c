using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0.ViewModels
{
    public class TransferenciaViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CvuOrigen { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CvuDestino { get; set; }
        public decimal Monto { get; set; }
    }
}
