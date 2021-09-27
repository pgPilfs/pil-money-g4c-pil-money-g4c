using APPO_2._0_.Models;
using APPO_2._0_.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPO_2._0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly APPO20Context _context;
        public ActividadController(APPO20Context context)
        {
            _context = context;

        }
        
        
        
    }
}
