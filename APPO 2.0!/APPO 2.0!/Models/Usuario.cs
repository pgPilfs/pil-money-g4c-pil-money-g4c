using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte[] FotoDniFrente { get; set; }
        public byte[] FotoDniDorso { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
