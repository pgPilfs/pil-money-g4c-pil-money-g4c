using APPO_2._0.ViewModels;
using APPO_2._0_.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CuentaController : ControllerBase
    {
        private readonly APPO20Context _context;
        public CuentaController(APPO20Context context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                var lista = _context.Cuentas.ToList();
                var listaView = lista.Select(x => new CuentaViewModel
                {
                    Cvu = Convert.ToString(x.Cvu),
                    SaldoActual = x.SaldoActual
                 }).ToList();
                var listaFinal = listaView.Where(var => var.Cvu == "236598752013654875").ToList();
                return Ok(listaFinal);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        /*
        //get actividades de la cuenta
        [HttpGet]
        public IActionResult GetActividades()
        {

            try
            {
                var actividades = _context.Cuentas.Include(p => p.PagosServicios)
                                                  .Include(i => i.Inversiones)
                                                  .Include(r => r.RetirosDineros)
                                                  .Include(ing => ing.IngresosDineros)
                                                  .Include(t => t.TransferenciaCvuDestinoNavigations);

                 PagosServicio p = new PagosServicio();
                 if (p != null)
                 {
                     p.NombreFactura.ToList();
                 }

                 Inversione i = new Inversione();
                 if (i != null)
                 {
                     i.MontoInversion.ToString().ToList();
                 }

                if (actividades == null)
                {
                    return NotFound();
                }
                return Ok(actividades);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }


        }
*/
    }
}
