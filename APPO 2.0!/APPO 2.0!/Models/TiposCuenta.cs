﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APPO_2._0_.Models
{
    public partial class TiposCuenta
    {
        public TiposCuenta()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int IdTipoCuenta { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
