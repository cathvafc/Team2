using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Categorias
    {
        public Categorias()
        {
            Trabajadores = new HashSet<Trabajadores>();
            Clase_Personas = new HashSet<Clase_Persona>();
        }

        public string CATEGORI { get; set; }
        public string DESCRIP { get; set; }
        public string CUERPO { get; set; }
        public string ID_CLASE_PER { get; set; }
        public string ID_SUBESCALA { get; set; }
        public string ID_CLASE { get; set; }
        public string ID_ESCALA { get; set; }
        public DateTime F_INI_VIGEN { get; set; }
        public DateTime F_FIN_VIGEN { get; set; }
        public string D_FUNCIONES { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER { get; set; }
        public string OBSERVAC { get; set; }
  
        public ICollection<Trabajadores> Trabajadores { get; set; }
        public ICollection<Clase_Persona> Clase_Personas { get; set; }


    }
}
