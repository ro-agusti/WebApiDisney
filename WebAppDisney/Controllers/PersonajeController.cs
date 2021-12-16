 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebAppDisney.Data;
using WebAppDisney.Models;

namespace WebAppDisney.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        private readonly DisneyDbContext context;
        public PersonajeController(DisneyDbContext context)
        {
            this.context = context;
        }

    }
}
