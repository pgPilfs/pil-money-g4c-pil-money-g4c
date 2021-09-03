using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace APPO.Models
{
    public partial class Servicio
    {

        public class APPOContext : DbContext
        {

        }
        public Servicio()
        {
            PagosServicios = new HashSet<PagosServicio>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }

        public virtual ICollection<PagosServicio> PagosServicios { get; set; }
    }
}
