using APPO_2._0_.Models;
using APPO_2._0_.Models.ViewModels;
using APPO_2._0_.Response;
using APPO_2._0_.Services;
using APPO_2._0_.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly APPO20Context _context;
        public RegistroController(APPO20Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RegistroViewModel oModelRegistro)
        {
            try
            {
                Usuario usu = new Usuario();
                Cuenta cuenta = new Cuenta();

               

                usu.Dni = oModelRegistro.Dni;
                usu.Nombre = oModelRegistro.Nombre;
                usu.Apellido = oModelRegistro.Apellido;
                usu.FotoDniFrente = Encoding.ASCII.GetBytes(oModelRegistro.FotoDniFrente);
                usu.FotoDniDorso = Encoding.ASCII.GetBytes(oModelRegistro.FotoDniDorso);
                usu.Mail = oModelRegistro.Mail;
                usu.Password = Encrypt.GetSHA256(oModelRegistro.Password);

                

                var nuevo_usuario = usu.Dni;
                var existente_usuario = _context.Usuarios.Where(u => u.Dni == nuevo_usuario);

                if (existente_usuario == null)
                {
                    return BadRequest("Ya existe una cuenta con este numero de documento");
                }
                else
                {
                    _context.Usuarios.Add(usu);

                    await _context.SaveChangesAsync();



                    //cuenta.IdUsuarioNavigation = usu.IdUsuario;

                    //var lista1 = _context.Cuentas.Include(i => i.IdUsuarioNavigation).ToList().Last();

                    //var a = Convert.ToInt32(lista1);
                    //cuenta.IdUsuario = a;


                   // cuenta.SaldoActual = 100;
                    //cuenta.IdTipoCuenta = 1;
                    //cuenta.Alias = "alias.por.defecto";

                   // _context.Cuentas.Add(cuenta);


                    return Ok(usu);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }

        }





    }
}
