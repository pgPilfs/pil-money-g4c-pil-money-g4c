using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Models.ViewModels
{
    public class RegistroViewModel
    {
        public int IdUsuario { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public byte[] FotoDniFrente { get; set; }
        public byte[] FotoDniDorso { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
