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
        
        //Función para generar la tabla de departamentos con los parámetros especificados
        private static readonly Expression<Func<NivOrg, DepartamentoDto>> AsTablaDepartamentoDto =

       d => new DepartamentoDto

       {
           CAMINO = d.Camino,
           NOMBRE = d.DNivel
       };

        //Se asigna el contexto pasado por parámetro a un contexto local 
        public DepartamentoController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Departamento
        //Devuelve la lista de departamentos para mostrar en el menú en formato Json
        [HttpGet]
        public  string GetDepartamento()
        {
            //Se obtiene del contexto la lista de departamentos sin filtrar por el campo camino
            var lista = _context.NivOrg.Select(AsTablaDepartamentoDto);

            //Lista donde se guardaran los departamentos que cumplen con el filtro
            List<DepartamentoDto> lista2 = new List<DepartamentoDto>();

            //Se añade el departamento a la lista si el tamaño del atributo CAMINO es menor a 12
            foreach (DepartamentoDto item in lista)
            {
                if (item.CAMINO.Length < 12)
                {
                    lista2.Add(item);
                }
            }

            //Se convierte la lista a formato json
            var output = JsonConvert.SerializeObject(lista2, Formatting.Indented);

            Thread.Sleep(500);

            return output;

        }
    }
}
