
using APPO_2._0_.Models;
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
        private readonly APPO20Context _context;
        public TipoCuentaController(APPO20Context context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                var lst = _context.TiposCuentas.ToList();
                return Ok(lst);
               


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
