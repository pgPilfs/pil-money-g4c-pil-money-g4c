using APPO_.Core.DTO;
using APPO_.Core.Interfaces;
using APPO_.Infraestructura.Repo;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly IServicioRepo _servicioRepo;
        private readonly IMapper _mapper;
        public ServicioController(IServicioRepo servicioRepo, IMapper mapper)
        {
            _servicioRepo = servicioRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetServicios()
        {
            var listaServicios = await _servicioRepo.GetServicios();
            var listaServiciosDto = _mapper.Map<IEnumerable<ServicioDTO>>(listaServicios);
            return Ok(listaServiciosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServicio(int id)
        {
            var listaServicio = await _servicioRepo.GetServicio(id);
            var listaServicioDto = _mapper.Map<ServicioDTO>(listaServicio);

            return Ok(listaServicioDto);
        }


        // GET: ServicioController/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
        
