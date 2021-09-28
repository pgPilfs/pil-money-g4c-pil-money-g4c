
using APPO_2._0.ViewModels;
using APPO_2._0_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoServicioController : ControllerBase
    {
        private readonly APPO20Context _context;
        public PagoServicioController(APPO20Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = _context.PagosServicios.Include(c => c.CvuPagoNavigation).OrderByDescending(f => f.Fecha).ToList();
                var listaInt = lista.Where(var => var.CvuPago == 236598752013654875).ToList();
                var listaView = listaInt.Select(x => new PagoServicioViewModel
                {
                    CvuPago = x.CvuPago,
                    NroFactura = x.NroFactura,
                    NombreFactura = x.NombreFactura,
                    Monto = x.Monto
                }).ToList();
                //var listaFinal = listaView.Where(var => var.CvuPago == 236598752013654875).ToList();
                return Ok(listaView);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PagoServicioViewModel oModel)
        {
            
            try
            {

                PagosServicio oPagos = new PagosServicio();
                //Cuenta cuenta = new Cuenta();

                var cvu_origen = Convert.ToInt64(oModel.CvuPago);
                var cuenta = _context.Cuentas.Where(c => c.Cvu == cvu_origen).FirstOrDefault();


                if (oModel.NombreFactura == "CABLEVISION")
                {
                    oPagos.IdServicio = 1;

                }
                if (oModel.NombreFactura == "EPEC")
                {
                    oPagos.IdServicio = 2;

                }
                if (oModel.NombreFactura == "AGUAS CORDOBESAS")
                {
                    oPagos.IdServicio = 3;

                }
                if (oModel.NombreFactura == "ECOGAS")
                {
                    oPagos.IdServicio = 4;

                }
                if (oModel.NombreFactura == "RENTAS")
                {
                    oPagos.IdServicio = 5;

                }
                if (oModel.NombreFactura == "FIBERTEL")
                {
                    oPagos.IdServicio = 6;

                }
                if (oModel.NombreFactura == "TELECOM")
                {
                    oPagos.IdServicio = 7;

                }

                oPagos.CvuPago = oModel.CvuPago;
                oPagos.NroFactura = oModel.NroFactura;
                oPagos.NombreFactura = oModel.NombreFactura;
                oPagos.Monto = oModel.Monto;
                oPagos.Fecha = DateTime.Now;


                decimal total = oModel.Monto;

                if (cuenta == null)
                {
                    return BadRequest("Lo sentimos...Las cuenta de la que intentas realizar el pago no existe...");
                }

                if (cuenta.SaldoActual < total)
                {
                    return BadRequest("Lo sentimos... Tu cuenta no tiene el el dinero suficiente para realizar el pago");
                }
                else
                {
                    cuenta.SaldoActual -= total;
                    _context.Cuentas.Update(cuenta);
                }

                _context.PagosServicios.Add(oPagos);

                await _context.SaveChangesAsync();
                return Ok(oPagos);
                    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
