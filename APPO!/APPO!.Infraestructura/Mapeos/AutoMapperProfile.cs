using APPO_.Core.DTO;
using APPO_.Core.Entidades;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPO_.Infraestructura.Mapeos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Servicio, ServicioDTO>();

            CreateMap<IngresosDineroDTO, IngresosDinero>();

        }
    }
}
