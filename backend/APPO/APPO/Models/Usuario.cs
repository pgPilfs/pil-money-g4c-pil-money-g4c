using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPO.Models
{
  public class Usuario
  {
    public int dni { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public byte foto_dni_frente { get; set; }
    public byte foto_dni_dorso { get; set; }
    public string email { get; set; }
    public string password { get; set; }

  }
}
