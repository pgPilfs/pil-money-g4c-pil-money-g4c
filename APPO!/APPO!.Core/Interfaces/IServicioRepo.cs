using APPO_.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Core.Interfaces
{
    public interface IServicioRepo
    {
        Task<IEnumerable<Servicio>> GetServicios();
        Task<Servicio> GetServicio(int id);
    }
}
