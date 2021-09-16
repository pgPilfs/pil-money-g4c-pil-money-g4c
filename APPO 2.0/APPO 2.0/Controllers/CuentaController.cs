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
        public IActionResult Get(Cuenta oCuenta)
        {
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    CuentaViewModel oModel = new CuentaViewModel();
                    oModel.Cvu = oCuenta.Cvu;
                    oModel.SaldoActual = oCuenta.SaldoActual;
                    var lista = db.Cuentas.ToList();
                    return Ok(lista);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
    }

    [HttpPost]
    public IActionResult Add(ServicioViewModel oModel)
    {
        Response oRespuesta = new Response();
        oRespuesta.Exito = 0;
        try
        {
            using (APPO20Context db = new APPO20Context())
            {
                Servicio oServicio = new Servicio();
                oServicio.NombreServicio = oModel.NombreServicio;
                db.Servicios.Add(oServicio);
                db.SaveChanges();
                oRespuesta.Exito = 1;

            }

        }
        catch (Exception ex)
        {
            oRespuesta.Mensaje = ex.Message;
        }

        return Ok(oRespuesta);


    }
}
