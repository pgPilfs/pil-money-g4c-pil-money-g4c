using APPO_.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Core.Interfaces
{
    public interface ITransferenciaRepo
    {
        Task InsertTransferencia(Transferencia transferencia);
    }
}
