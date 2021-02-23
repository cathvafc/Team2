using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Categorias
    {
        public char CATEGORI { get; set; }
        public string DESCRIP { get; set; }
        public char CUERPO { get; set; }
        public char ID_CLASE_PER { get; set; }
        public char ID_SUBESCALA { get; set; }
        public char ID_CLASE { get; set; }
        public char ID_ESCALA { get; set; }
        public DateTime F_INI_VIGEN { get; set; }
        public DateTime F_FIN_VIGEN { get; set; }
        public string D_FUNCIONES { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER { get; set; }
        public string OBSERVAC { get; set; }
    }
}
