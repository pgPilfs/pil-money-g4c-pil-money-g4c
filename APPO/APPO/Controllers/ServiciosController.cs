using APPO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APPO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private readonly APPOContext _context;

        public ServiciosController(APPOContext context)
        {
            _context = context;

        }
        // GET: api/<ServiciosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listServicios = await _context.Servicios.ToListAsync();
                return Ok(listServicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ServiciosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ServiciosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServiciosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
