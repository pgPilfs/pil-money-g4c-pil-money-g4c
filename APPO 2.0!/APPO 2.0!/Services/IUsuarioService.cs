using APPO_2._0_.Models.Response;
using APPO_2._0_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Services
{
    public interface IUsuarioService
    {
        UserResponse Auth(UsuarioViewModel model);
    }
}
