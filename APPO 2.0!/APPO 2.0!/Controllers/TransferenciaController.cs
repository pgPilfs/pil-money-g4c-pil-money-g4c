using APPO_2._0_.Models;
using APPO_2._0_.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(TransferenciaViewModel oModel)
        {
            using (APPO20Context db = new APPO20Context())
            {
                Transferencia oTransferencia = new Transferencia();
                oTransferencia.CvuOrigen = oModel.CvuOrigen;
                oTransferencia.CvuDestino = oModel.CvuDestino;
                oTransferencia.Monto = oModel.Monto;
                db.Transferencias.Add(oTransferencia);
                db.SaveChanges();
                return Ok(oTransferencia);
            }

        }
    }
}
