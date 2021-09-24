using APPO_2._0_.Models.ViewModels;
using APPO_2._0_.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Services
{
    public interface IUserService
    {
        UserResponse Auth(UsuarioViewModel oModel);
    }
}
