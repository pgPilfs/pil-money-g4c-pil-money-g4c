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
    public class TransferenciaController : Controller
    {
        private readonly ITransferenciaRepo _transferenciaRepo;
        public TransferenciaController(ITransferenciaRepo transferenciaRepo)
        {
            _transferenciaRepo = transferenciaRepo;
        }
        [HttpPost]
        public async Task<IActionResult> PostTransferencia(Transferencia transferencia)
        {
            await _transferenciaRepo.InsertTransferencia(transferencia);
            return Ok(transferencia);
        }
    }
}
