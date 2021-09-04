using APPO_.Core.Entidades;
using APPO_.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosDineroController : Controller
    {
        private readonly IIngresoDineroRepo _ingresoRepo;
        public IngresosDineroController(IIngresoDineroRepo ingresoRepo)
        {
            _ingresoRepo = ingresoRepo;
        }
        [HttpPost]
        public async Task<IActionResult> PostIngreso(IngresosDinero ingreso)
        {
            await _ingresoRepo.InsertDinero(ingreso);
            return Ok(ingreso);
        }
    }
}
