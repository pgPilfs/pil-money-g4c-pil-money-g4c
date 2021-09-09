using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_.Core.Entidades
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
