using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team2.Models;
using Team2.DTO;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;

namespace Team2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly APIContext _context;

        //DTOs

        private static readonly Expression<Func<Trabajadores, TrabajadoresDto>> AsTablaTrabajadoresDto =
            
            t => new TrabajadoresDto

            {
                CAMINO = t.NivelOrganizativo.Camino,
                ID_TRABAJADOR = t.ID_TRABAJADOR.ToString(),
                EMPRESA = t.empresa.D_EMPRESA,
                NOMBRE = t.NOMBRE + " " + t.APELLIDO1 + " " + t.APELLIDO2,
                TP = t.t_Provincia.ID_CLASE_PER.ToString(),
                TIPO_EMPRESA = t.t_Provincia.DESCRIP,
                GRUPO = t.GRUPO.ToString(),
                CUERPO = t.Cuerpo.DESCRIP,
                CATEGORIA = t.categorias.DESCRIP

            };


        public TrabajadoresController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Trabajadores
        [HttpGet]
        public  IQueryable<TrabajadoresDto> GetTablaTrabajadores()
        {
            return  _context.Trabajadores.Select(AsTablaTrabajadoresDto);
        }


        private bool TrabajadoresExists(char id)
        {
            return _context.Trabajadores.Any(e => e.ID_EMPRESSA == id);
        }
    }
}
