using APPO_.Core.Entidades;
using APPO_.Core.Interfaces;
using APPO_.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Infraestructura.Repo
{
    public class IngresoDineroRepo : IIngresoDineroRepo
    {
        private readonly APPOContext _context;

        public IngresoDineroRepo(APPOContext context)
        {
            _context = context;
        }

        public async Task InsertDinero(IngresosDinero ingreso)
        {
            _context.IngresosDineros.Add(ingreso);
            await _context.SaveChangesAsync();
        }
    }
}
