using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Empresa
    {

        public Empresa()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public char ID_EMPRESA { get; set; }
        public string D_EMPRESA  { get; set; }
        public char SIGLAS  { get; set; }
        public string DOMICILIO  { get; set; }
        public string NUM { get; set; }
        public string KM { get; set; }
        public string ESCALERA { get; set; } 
        public string PISO { get; set; }
        public string PUERTA { get; set; }
        public string CPOSTAL { get; set; }
        public char ID_PROVINCIA { get; set; }
        public char ID_POBLACION { get; set; }
        public string TELEFONO1 { get; set; }
        public string TELEFONO2 { get; set; }
        public string NIF { get; set; }
        public int ID { get; set; }
        public DateTime GCROWVER  { get; set; }

        public ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
