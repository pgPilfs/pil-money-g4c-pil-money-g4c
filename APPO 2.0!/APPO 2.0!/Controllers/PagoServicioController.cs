
using APPO_2._0.ViewModels;
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
    public class PagoServicioController : ControllerBase
    {
        private readonly APPO20Context _context;
        public PagoServicioController(APPO20Context context)
        {
            _context = context;
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

                    cuenta.SaldoActual -= total;
                    _context.Cuentas.Update(cuenta);

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
