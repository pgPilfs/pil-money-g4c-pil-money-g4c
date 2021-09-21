using APPO_2._0_.Models;
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
        public UsuarioController(APPO20Context context)
        {
            _context = context;

        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listUsers = await _context.Usuarios
                                            .Include(u => u.Cuenta).                                         
                                            ToListAsync();

                return Ok(listUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*// GET api/<UserController>/5

        [HttpGet("{idUser}")]
        public async Task<IActionResult> Get(string idUser)
        {
            try
            {
                var userID = await _context.Users
                                            .Include(u => u.Tarjetas)
                                            .Include(u => u.Pagos)
                                            .Include(u => u.Cuentas)
                                            .Include(u => u.Cuentas)
                                                .ThenInclude(c => c.TipoMoneda)
                                            .Where(u => u.id_user == idUser)
                                            .FirstOrDefaultAsync();

                if (userID == null)
                {
                    return NotFound();
                }

                return Ok(userID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario user)
        {
            try
            {
                _context.Usuarios.Add(user);
                await _context.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*// PUT api/<UserController>/5
        [HttpPut("{idUser}")]
        public async Task<IActionResult> Put(string idUser, [FromBody] Users user)
        {
            try
            {
                if (idUser != user.id_user)
                {
                    return BadRequest(new { message = "Error del id user" });
                }

                _context.Update(user);
                await _context.SaveChangesAsync();
                return Ok(new { message = "User actualizado con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{idUser}")]
        public async Task<IActionResult> Delete(string idUser)
        {
            try
            {
                var userID = await _context.Users.FindAsync(idUser);

                if (userID == null)
                {
                    return NotFound();
                }

                //Para eliminar un usuario tenemos que eliminar todas sus relaciones con las clases
                var cuentasList = await _context.Cuentas.Where(c => c.id_user == idUser).ToListAsync();


                foreach (var c in cuentasList)
                {
                    _context.Depositos.RemoveRange(_context.Depositos.Where(d => d.cvu == c.cvu));
                    _context.Envios.RemoveRange(_context.Envios.Where(e => e.cvu == c.cvu));

                }

                _context.Cuentas.RemoveRange(cuentasList);

                var tar = _context.Tarjetas.Where(t => t.id_user == idUser);
                _context.Tarjetas.RemoveRange(tar);

                _context.Users.Attach(userID);
                _context.Users.Remove(userID);

                await _context.SaveChangesAsync();

                return Ok(new { message = "Usuario eliminado con exito! " });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }
        }
        */

    }
}
