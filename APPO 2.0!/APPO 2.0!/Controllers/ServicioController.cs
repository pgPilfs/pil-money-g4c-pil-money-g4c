using APPO_2._0_.Models;
using APPO_2._0_.Models.Response;
using APPO_2._0_.ViewModels;
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
    public class ServicioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (APPO20Context db = new APPO20Context())
            {
                var lst = db.Servicios.ToList();
                return Ok(lst);
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

        [HttpPut]
        public IActionResult Edit(ServicioViewModel oModel)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    Servicio oServicio = db.Servicios.Find(oModel.IdServicio);
                    oServicio.NombreServicio = oModel.NombreServicio;
                    db.Entry(oServicio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Response oRespuesta = new Response();
            oRespuesta.Exito = 0;
            try
            {
                using (APPO20Context db = new APPO20Context())
                {
                    Servicio oServicio = db.Servicios.Find(Id);
                    db.Remove(oServicio);
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
}
