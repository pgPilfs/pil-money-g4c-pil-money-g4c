using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Inversione
    {
        [Key]
        public int IdInversion { get; set; }
        public decimal MontoInversion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        [Required]
        public long CvuInversion { get; set; }

        public virtual Cuenta CvuInversionNavigation { get; set; }
    }
}
