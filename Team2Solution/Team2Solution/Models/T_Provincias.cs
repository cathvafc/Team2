using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class T_Provincias
    {
        public T_Provincias()
        {
            trabajadores = new HashSet<Trabajadores>();
        }

        public string T_PROVIS { get; set; }
        public string DESCRIP { get; set; }
        public string ID_CLASE_PER { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER { get; set; }

        public ICollection<Trabajadores> trabajadores { get; set; }

    }
}
