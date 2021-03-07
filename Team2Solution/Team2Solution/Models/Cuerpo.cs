using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Cuerpo
    {
        public Cuerpo()
        {
            trabajadores = new HashSet<Trabajadores>();
        }

        //Atributos del modelo Cuerpo
        public string CUERPO { get; set; }
        public string DESCRIP { get; set; }
        public string CATEGOR { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER { get; set; }
        public ICollection<Trabajadores> trabajadores { get; set; }
    }
}
