using APPO_2._0.ViewModels;
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
        public IActionResult Get()
        {
            try
            {
                var lista = _context.Inversiones.Include(c => c.CvuInversionNavigation).ToList();
                var listaInt = lista.Where(var => var.CvuInversion == 236598752013654875).ToList();
                var listaView = listaInt.Select(x => new InversionViewModel
                {
                    CvuInversion = Convert.ToString(x.CvuInversion),
                    MontoInversion = x.MontoInversion,
                    FechaFin = x.FechaFin
                }).ToList();
                //var listaFinal = listaView.Where(var => var.CvuPago == 236598752013654875).ToList();
                return Ok(listaView);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET api/<InversionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InversionController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] InversionViewModel oModelInversion)
            {
            try
            {
                Inversione inv = new Inversione();
                //Cuenta cuenta = new Cuenta();

                var cvu_origen = Convert.ToInt64(oModelInversion.CvuInversion);
                var cuenta = _context.Cuentas.Where(c => c.Cvu == cvu_origen).FirstOrDefault();
                //var cuentaInv = _context.Inversiones.Where(i => i.CvuInversion == oModelInversion.CvuInversion).FirstOrDefault();
                //cuenta.Cvu = cuentaInv.CvuInversion;
                //cuenta.Cvu = oModelInversion.CvuInversion;
                inv.CvuInversion = Convert.ToInt64(oModelInversion.CvuInversion);
                inv.FechaFin = oModelInversion.FechaFin;
                inv.FechaInicio = DateTime.Now;
                inv.MontoInversion = oModelInversion.MontoInversion;


                decimal total = oModelInversion.MontoInversion;

                if (cuenta == null)
                {
                    return BadRequest("Lo sentimos...Las cuenta de la que intentas realizar la inversion no existe...");
                }
                
                if (cuenta.SaldoActual < total)
                {
                    return BadRequest("Lo sentimos... Tu cuenta no tiene el el dinero suficiente para realizar una inversion");
                }
                else
                {
                    cuenta.SaldoActual -= total;
                    _context.Cuentas.Update(cuenta);
                }
                    
                _context.Inversiones.Add(inv);
              
                await _context.SaveChangesAsync();
                return Ok(inv);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }

        }

    }
}
