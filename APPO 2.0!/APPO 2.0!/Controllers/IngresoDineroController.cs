using APPO_2._0_.Models;
using APPO_2._0_.Models.ViewModels;
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
    public class IngresoDineroController : ControllerBase
    {
        private readonly APPO20Context _context;
        public IngresoDineroController(APPO20Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] IngresoDineroViewModel oModelIngreso)
        {
            try
            {
                IngresosDinero ing = new IngresosDinero();
                //Cuenta cuenta = new Cuenta();

                var cvu_inversion = Convert.ToInt64(oModelIngreso.CvuDeposito);
                var cuenta = _context.Cuentas.Where(c => c.Cvu == cvu_inversion).FirstOrDefault();

                ing.NombreDeposito = "Sin nombre";  
                ing.CvuDeposito = Convert.ToInt64(oModelIngreso.CvuDeposito);
                ing.NroTarjeta = oModelIngreso.NroTarjeta;
                ing.FechaVenc = oModelIngreso.FechaVenc;
                ing.CodSeguridad = oModelIngreso.CodSeguridad;
                ing.NombreTitular = oModelIngreso.NombreTitular;
                ing.Monto = oModelIngreso.Monto;

                //reserva por si hay que verificar si la tarjeta tiene fondos
                decimal total = oModelIngreso.Monto;

                if (cuenta == null)
                {
                    return BadRequest("Lo sentimos...Las cuenta de la que intentas realizar el ingreso de dinero no existe...");
                }

                /*if (cuenta.SaldoActual < total)
                {
                    return BadRequest("Lo sentimos... Tu cuenta no tiene el el dinero suficiente para realizar una inversion");
                }
                else
                {
                    cuenta.SaldoActual -= total;
                    _context.Cuentas.Update(cuenta);
                }*/

                if (ing.FechaVenc < DateTime.Now)
                {
                    return BadRequest("Tarjeta vencida!");
                }

                cuenta.SaldoActual += total;
                _context.Cuentas.Update(cuenta);

                _context.IngresosDineros.Add(ing);

                await _context.SaveChangesAsync();
                return Ok(ing);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }

        }
    }
}
