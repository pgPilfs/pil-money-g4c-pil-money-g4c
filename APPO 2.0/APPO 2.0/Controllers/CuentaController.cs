using APPO_2._0.Models;
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
    public class CuentaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
           
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    
                    var lista = db.Cuentas.ToList();
                    var listaView = lista.Select(x => new CuentaViewModel
                    {
                        Cvu = x.Cvu,
                        SaldoActual = x.SaldoActual
                    }).ToList();
                    var listaFinal = listaView.Where(var => var.Cvu == "1934569876123459875687").ToList();
                    return Ok(listaFinal);
                }
                

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
    }

}
