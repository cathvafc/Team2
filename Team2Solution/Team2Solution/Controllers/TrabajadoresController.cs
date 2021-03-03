
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team2.Models;
using Microsoft.AspNetCore.Authorization;
using Team2.DTO;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace Team2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly APIContext _context;


        //Añadir funciones para calcular los trabajadores por diferentes grupos y tipo de empleado.
    }
}
