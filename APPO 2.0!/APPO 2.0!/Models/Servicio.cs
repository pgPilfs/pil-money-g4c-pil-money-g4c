using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            PagosServicios = new HashSet<PagosServicio>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }

        public virtual ICollection<PagosServicio> PagosServicios { get; set; }
    }
}
