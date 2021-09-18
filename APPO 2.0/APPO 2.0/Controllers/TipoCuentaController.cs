using APPO_2._0.Models;
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
    public class TipoCuentaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                using (APPO20Context db = new APPO20Context())
                {

                    var lst = db.TiposCuentas.ToList();
                    return Ok(lst);
                }


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
