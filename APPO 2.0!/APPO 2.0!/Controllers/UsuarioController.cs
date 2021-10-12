using APPO_2._0_.Models;
using APPO_2._0_.Models.ViewModels;
using APPO_2._0_.Response;
using APPO_2._0_.Services;
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
    public class UsuarioController : ControllerBase
    {
        private readonly APPO20Context _context;
        private IUserService _userService;
        public UsuarioController(APPO20Context context, IUserService userService)
        {
            _context = context;
            _userService = userService;

        }

        // GET: api/<UserController>
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                //UsuarioViewModel oModel = new UsuarioViewModel();
                Usuario user = new Usuario();

                var listUsers = await _context.Usuarios
                                            .Include(u => u.Cuenta).Where(u => u.Nombre == "Lautaro").
                                            ToListAsync();

                return Ok(listUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // POST api/<UserController>
        [HttpPost]
        
        public IActionResult Autentificar([FromBody] UsuarioViewModel oModel)
        {
            Respuesta rta = new Respuesta();
            var userresponse = _userService.Auth(oModel);

            if (userresponse == null)
            {
                rta.Exito = 0;
                rta.Mensaje = "Usuario o contraseña incorrecta";
                return BadRequest(rta);
            }

            rta.Exito = 1;
            rta.Data = userresponse;
            return Ok(rta);
        }
        


        [HttpPut]

        public async Task<IActionResult> Edit([FromBody] Usuario user)
        {
            try
            {
                Usuario usu_viejo = new Usuario();

                usu_viejo.FotoDniFrente = user.FotoDniFrente;
                usu_viejo.FotoDniDorso = user.FotoDniDorso;
                usu_viejo.Mail = user.Mail;
                usu_viejo.Password = user.Password;

                _context.Update(usu_viejo);
                await _context.SaveChangesAsync();
                return Ok(new { message = "User actualizado con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }
        }

    }
}
