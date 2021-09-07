using APPO_.Core.DTO;
using APPO_.Core.Entidades;
using APPO_.Core.Interfaces;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public TransferenciaController(ITransferenciaRepo transferenciaRepo, IMapper mapper)
        {
            _transferenciaRepo = transferenciaRepo;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> PostTransferencia(TransferenciaDTO transferenciaDto)
        {
            var transferencia = _mapper.Map<Transferencia>(transferenciaDto);
            await _transferenciaRepo.InsertTransferencia(transferencia);
            return Ok(transferencia);
        }
    }
}
