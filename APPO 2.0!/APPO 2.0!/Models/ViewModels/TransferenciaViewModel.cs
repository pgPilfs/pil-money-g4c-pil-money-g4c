﻿using APPO_2._0_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0.ViewModels
{
    public class TransferenciaViewModel
    {
        public string CvuOrigen { get; set; }
        public string CvuDestino { get; set; }
        public decimal Monto { get; set; }
    }
}
