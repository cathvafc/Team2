using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Clase_Persona
    {
        public Clase_Persona()
        {
            categorias = new HashSet<Categorias>();

        }

        //Atributos del modelo Clase_Persona
        public string ID_CLASE_PER { get; set; }
        public string D_CLASE_PER { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER { get; set; }
        public string ASIMILADO { get; set; }

        public ICollection<Categorias> categorias { get; set; }
    }
}
