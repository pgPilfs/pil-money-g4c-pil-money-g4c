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
    public class InversionController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] InversionViewModel oModel)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {

                    Inversione oInversion = new Inversione();
                    oInversion.MontoInversion = oModel.MontoInversion;
                    oInversion.FechaInicio = DateTime.Now;
                    oInversion.FechaFin = oModel.FechaFin;
                    oInversion.CvuInversion = "2262954820126236189574";
                    db.Inversiones.Add(oInversion);
                    await db.SaveChangesAsync();
                    return Ok(oInversion);

                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
