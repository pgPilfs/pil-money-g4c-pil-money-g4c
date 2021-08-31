using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPO.Models
{
  public class Servicio
  {
    private int idServicio;
    private string nombreServicio;


    public Servicio(int idServicio, string nombreServicio)
    {
      this.idServicio = idServicio;
      this.nombreServicio = nombreServicio;

    }

    public int IdServicio { get => idServicio; set => idServicio = value; }
    public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }
  }
}
}
