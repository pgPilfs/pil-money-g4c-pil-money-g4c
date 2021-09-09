using APPO_.Core.Entidades;
using APPO_.Core.Interfaces;
using APPO_.Infraestructura.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Infraestructura.Repo
{
    public class ServicioRepo : IServicioRepo
    {
        private readonly APPOContext _context;

        public ServicioRepo(APPOContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Servicio>> GetServicios()
        {
            var listaServicios = await _context.Servicios.ToListAsync();
            return listaServicios;

        }

        public async Task<Servicio> GetServicio(int id)
        {
            var listaServicio = await _context.Servicios.FirstOrDefaultAsync(x => x.IdServicio == id);
            return listaServicio;

        }   
    }
}
