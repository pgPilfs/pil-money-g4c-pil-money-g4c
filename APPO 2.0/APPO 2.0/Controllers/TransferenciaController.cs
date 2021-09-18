using APPO_2._0.Models;
using APPO_2._0.Models.Response;
using APPO_2._0.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        /*[HttpPost]
        public IActionResult Add(TransferenciaViewModel oModel)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    Transferencia oTransferencia = new Transferencia();
                    oTransferencia.NroTransferencia = oTransferencia.NroTransferencia;
                    oTransferencia.CvuOrigen = oModel.CvuOrigen;
                    oTransferencia.CvuDestino = oModel.CvuDestino;
                    oTransferencia.Fecha = oTransferencia.Fecha;
                    oTransferencia.Hora = oTransferencia.Hora;
                    oTransferencia.Monto = oModel.Monto;
                    oTransferencia.Referencia = oTransferencia.Referencia;
                    db.Transferencias.Add(oTransferencia);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = oTransferencia;

                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }*/
        /*protected override void APPO20Context(ModelBuilder builder)
        {
            using (APPO20Context db = new APPO20Context())
            {
                base.ControllerContext(builder);
            }
                base.ControllerContext(builder);
            var keysProperties = builder.Model.GetEntityTypes().Select(x => x.FindPrimaryKey()).SelectMany(x => x.Properties);
            foreach (var property in keysProperties)
            {
                property.ValueGenerated = ValueGenerated.OnAdd;
            }
        }
        */
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TransferenciaViewModel oModel)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    Cuenta oCuenta = new Cuenta();
                    Transferencia oTransferencia = new Transferencia();
                    oTransferencia.CvuOrigen = oModel.CvuOrigen;
                    oTransferencia.CvuDestino = oModel.CvuDestino;
                    oTransferencia.Fecha = DateTime.Now;
                    oTransferencia.Monto = oModel.Monto;
                    oTransferencia.Referencia = "transferencia";
                    db.Transferencias.Add(oTransferencia);
                    await db.SaveChangesAsync();
                    return Ok(oTransferencia);

                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
