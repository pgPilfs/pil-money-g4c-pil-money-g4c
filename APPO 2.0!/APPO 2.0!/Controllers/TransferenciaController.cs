using APPO_2._0.ViewModels;
using APPO_2._0_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    public class TransferenciaController : ControllerBase
    {
        private readonly APPO20Context _context;
        public TransferenciaController(APPO20Context context)
        {
            _context = context;
        }
        // GET: api/<TransferenciaController>
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            try
            {
                var lista = _context.Cuentas.Include(c => c.TransferenciaCvuDestinoNavigations).ToList();
                var listaView = lista.Select(x => new CuentaViewModel
                {
                    Cvu = Convert.ToString(x.Cvu)
                }).ToList();

                var listaFinal = listaView.Where(var => var.Cvu == "236598752013654875").ToList();
                return Ok(listaFinal);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

       

        // GET api/<TransferenciaController>/5  
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TransferenciaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TransferenciaViewModel oModel)
        {

            try
            {

                Transferencia transf = new Transferencia();
                //Cuenta cuenta = new Cuenta();

                var cvu_origen = Convert.ToInt64(oModel.CvuOrigen);
                var cuenta = _context.Cuentas.Where(c => c.Cvu == cvu_origen).FirstOrDefault();

                transf.CvuOrigen = Convert.ToInt64(oModel.CvuOrigen);
                transf.CvuDestino = Convert.ToInt64(oModel.CvuDestino);
                transf.Fecha = DateTime.Now;
                transf.Monto = oModel.Monto;
                transf.Referencia = "sin referencia";

                decimal total = oModel.Monto;

                cuenta.SaldoActual -= total;
                _context.Cuentas.Update(cuenta);


                /*await _context.Cuentas.FindAsync(inv);
                if (inv == null)
                {
                    return BadRequest("No posees esta cuenta");
                }*/

                //cuenta.SaldoActual -= inv.MontoInversion;
                //_context.Cuentas.Update(cuenta);

                //_context.Cuentas.Add(cuenta);
                _context.Transferencias.Add(transf);


                await _context.SaveChangesAsync();
                return Ok(transf);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // PUT api/<TransferenciaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TransferenciaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
