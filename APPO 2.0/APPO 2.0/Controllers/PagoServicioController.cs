using APPO_2._0.Models;
using APPO_2._0.Models.Response;
using APPO_2._0.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoServicioController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PagoServicioViewModel oModel)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {

                    PagosServicio oPagos = new PagosServicio();

                    if (oModel.NombreFactura == "CABLEVISION")
                    {
                        oPagos.IdServicio = 1;

                    }
                    if (oModel.NombreFactura == "EPEC")
                    {
                        oPagos.IdServicio = 2;

                    }
                    if (oModel.NombreFactura == "AGUAS CORDOBESAS")
                    {
                        oPagos.IdServicio = 3;

                    }
                    if (oModel.NombreFactura == "ECOGAS")
                    {
                        oPagos.IdServicio = 4;

                    }
                    if (oModel.NombreFactura == "RENTAS")
                    {
                        oPagos.IdServicio = 5;

                    }
                    if (oModel.NombreFactura == "FIBERTEL")
                    {
                        oPagos.IdServicio = 6;

                    }
                    if (oModel.NombreFactura == "TELECOM")
                    {
                        oPagos.IdServicio = 7;

                    }

                    oPagos.CvuPago = "2262954820126236189574";
                    oPagos.NroFactura = oModel.NroFactura;
                    oPagos.NombreFactura = oModel.NombreFactura;
                    oPagos.Monto = oModel.Monto;
                    oPagos.Fecha = DateTime.Now;

                    db.PagosServicios.Add(oPagos);
                    await db.SaveChangesAsync();
                    return Ok(oPagos);
                    


                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
