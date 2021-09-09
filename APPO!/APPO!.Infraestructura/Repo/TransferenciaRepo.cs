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
    public class TransferenciaRepo : ITransferenciaRepo
    {
        private readonly APPOContext _context;

        public TransferenciaRepo(APPOContext context)
        {
            _context = context;
        }
        public async Task InsertTransferencia(Transferencia transferencia)
        {
            _context.Transferencias.Add(transferencia);
            await _context.SaveChangesAsync();
        }
    }
}
