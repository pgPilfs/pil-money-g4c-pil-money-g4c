﻿using APPO_2._0.ViewModels;
using APPO_2._0_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InversionController : ControllerBase
    {
        private readonly APPO20Context _context;

        public InversionController(APPO20Context context)
        {
            _context = context;
        }
        // GET: api/<InversionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InversionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InversionController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] InversionViewModel oModelInversion)
            {
            try
            {
                Inversione inv = new Inversione();
                Cuenta cuenta = new Cuenta();

                //var cuentaInv = _context.Inversiones.Where(i => i.CvuInversion == oModelInversion.CvuInversion).FirstOrDefault();
                //cuenta.Cvu = cuentaInv.CvuInversion;
                cuenta.Cvu = oModelInversion.CvuInversion;
                inv.CvuInversion = oModelInversion.CvuInversion;
                inv.FechaFin = oModelInversion.FechaFin;
                inv.FechaInicio = DateTime.Now;
                inv.MontoInversion = oModelInversion.MontoInversion;



                /*await _context.Cuentas.FindAsync(inv);
                if (inv == null)
                {
                    return BadRequest("No posees esta cuenta");
                }*/

                //cuenta.SaldoActual -= inv.MontoInversion;
                //_context.Cuentas.Update(cuenta);

                //_context.Cuentas.Add(cuenta);
                _context.Inversiones.Add(inv);
              

                await _context.SaveChangesAsync();
                return Ok(inv);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException.Message);
            }

        }

    }
}
