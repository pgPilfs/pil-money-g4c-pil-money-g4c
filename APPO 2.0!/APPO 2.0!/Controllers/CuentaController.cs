using APPO_2._0_.Models;
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
    public class CuentaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (APPO20Context db = new APPO20Context())
            {
                var lst = db.Cuentas.ToList();
                return Ok(lst);
            }

        }

    }
}
