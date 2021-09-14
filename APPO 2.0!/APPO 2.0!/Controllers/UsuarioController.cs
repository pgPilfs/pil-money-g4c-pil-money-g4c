using APPO_2._0_.Models.Response;
using APPO_2._0_.Services;
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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

        }

        [HttpPost("login")]
        public IActionResult Autentificar([FromBody] UsuarioViewModel model)
        {
            Response respuesta = new Response();
            var userresponse = _usuarioService.Auth(model);
            if (userresponse == null)
            {
                respuesta.Exito = 0;
                respuesta.Mensaje = "Usuario o contraseña incorrectos";
                return BadRequest(respuesta);
            }
            respuesta.Exito = 1;
            respuesta.Data = userresponse;
            return Ok(respuesta);   

        }
    }
}
