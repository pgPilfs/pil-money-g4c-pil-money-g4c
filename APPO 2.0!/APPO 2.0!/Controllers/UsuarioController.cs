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
            var userresponse = _usuarioService.Auth(model);
            if (userresponse == null)
            {
                return BadRequest();
            }
            return Ok(model);   

        }
    }
}
