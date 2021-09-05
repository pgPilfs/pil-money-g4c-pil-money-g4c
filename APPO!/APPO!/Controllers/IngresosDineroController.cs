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
    public class IngresosDineroController : Controller
    {
        private readonly IIngresoDineroRepo _ingresoRepo;
        private readonly IMapper _mapper;
        public IngresosDineroController(IIngresoDineroRepo ingresoRepo, IMapper mapper)
        {
            _ingresoRepo = ingresoRepo;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> PostIngreso(IngresosDineroDTO ingresoDto)
        {
            var ingreso = _mapper.Map<IngresosDinero>(ingresoDto);

            await _ingresoRepo.InsertDinero(ingreso);
            return Ok(ingreso);
        }
    }
}
