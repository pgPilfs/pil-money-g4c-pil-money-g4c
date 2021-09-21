using APPO_2._0_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InversionController : ControllerBase
    {
        private readonly APPO20Context _context;

        public InversionController(APPO20Context context)
        {
            _context = context;
        }
        // GET: api/<InversionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InversionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InversionController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Inversione inversion)
        {
            try
            {
                Cuenta cuenta = new Cuenta();

                var inv = _context.Inversiones
                                       .Where(i => i.CvuInversion == 236598752013654875).FirstOrDefault();
                await _context.Cuentas.FindAsync(inv);
                if (inv == null)
                {
                    return BadRequest("No posees esta cuenta");
                }

                cuenta.SaldoActual -= inversion.MontoInversion;
                _context.Cuentas.Update(cuenta);

                _context.Inversiones.Add(inversion);

                await _context.SaveChangesAsync();
                return Ok(inversion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }

        }

    }
}
