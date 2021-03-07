using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team2.Models;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;
using Team2.DTO;
using Newtonsoft.Json;

namespace Team2Solution.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly APIContext _context;

        private static readonly Expression<Func<NivOrg, DepartamentoDto>> AsTablaDepartamentoDto =

       d => new DepartamentoDto

       {
           CAMINO = d.Camino,
           NOMBRE = d.DNivel
       };

        public DepartamentoController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Departamento
        //Devuelve la lista de departamentos para mostrar en el menú en formato Json
        [HttpGet]
        public  string GetDepartamento()
        {
            var lista = _context.NivOrg.Select(AsTablaDepartamentoDto);
            List<DepartamentoDto> lista2 = new List<DepartamentoDto>();
            foreach (DepartamentoDto item in lista)
            {
                if (item.CAMINO.Length < 12)
                {
                    lista2.Add(item);
                }
            }

            var output = JsonConvert.SerializeObject(lista2, Formatting.Indented);

            Thread.Sleep(500);

            return output;

        }
    }
}
