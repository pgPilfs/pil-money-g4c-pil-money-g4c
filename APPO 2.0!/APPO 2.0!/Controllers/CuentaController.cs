using APPO_2._0.ViewModels;
using APPO_2._0_.Models;
using APPO_2._0_.Models.ViewModels;
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
                    SaldoActual = x.SaldoActual,
                    Alias = x.Alias
                 }).ToList();
                var listaFinal = listaView.Where(var => var.Cvu == "236598752013654875").ToList();
                return Ok(listaFinal);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CuentaViewModel oModel)
        {
            try
            {
                Usuario usu = new Usuario();
                Cuenta cuenta = new Cuenta();


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
