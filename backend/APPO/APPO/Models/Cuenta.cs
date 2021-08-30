using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPO.Models
{
  public class Cuenta
  {
    public string CVU { get; set; }
    public string alias { get; set; }
    public int id_tipo_cuenta { get; set; }
    public float saldo_actual { get; set; }
    public int dni_usuario { get; set; }
  }
}
