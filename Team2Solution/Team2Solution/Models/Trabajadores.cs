using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class Trabajadores
    {
        public string APELLIDO1 { get; set; }
        public string APELLIDO2 { get; set; }
        public int CPOSTAL { get; set; }
        public char CUERPO { get; set; }
        public string DOMICILIO { get; set; }
        public char E_CIVIL { get; set; }
        public string EMAIL { get; set; }
        public char ES_FAMILIA_NUMEROSA { get; set; }
        public string ESCALERA { get; set; }
        public DateTime F_ALTA { get; set; }
        public DateTime F_BAJA { get; set; }
        public DateTime F_NAC { get; set; }
        public DateTime GCROWVER { get; set; }
        public char GRUPO { get; set; }
        public int HORAS_ANUAL { get; set; }
        public char HST_SIT_ADMV { get; set; }
        public int ID { get; set; }
        public char ID_CATEGORIA { get; set; }
        public char ID_EMPRESSA { get; set; }
        public int ID_HST_SIT_ADMV { get; set; }
        public char ID_NIVEL { get; set; }
        public char ID_ORGANIG { get; set; }
        public char ID_PAIS { get; set; }
        public char ID_PAIS_NAC { get; set; }
        public char ID_POBLACION { get; set; }
        public char ID_POBLACION_NAC { get; set; }
        public char ID_PROVINCIA { get; set; }
        public char ID_PROVINCIA_NAC { get; set; }
        public char ID_PUESTO { get; set; }
        public char ID_T_SIT_ADMV { get; set; }
        public char ID_TRABAJADOR { get; set; }
        public char MINUSV { get; set; }
        public string NIF { get; set; }
        public int NIV_ORG_ID { get; set; }
        public string NOMBRE { get; set; }
        public int NUM { get; set; }
        public decimal P_JORNADA_CTO { get; set; }
        public decimal P_JORNADA_TRAB { get; set; }
        public decimal P_OCUPACION { get; set; }
        public decimal P_REDUC_JORNADA { get; set; }
        public string PISO { get; set; }
        public string PUERTA { get; set; }
        public char RESIDENTE { get; set; }
        public char SEXO { get; set; }
        public char SIGLAS { get; set; }
        public char SIT_ADMV { get; set; }
        public char T_PROVIS { get; set; }
        public string TELEF_EMERG { get; set; }
        public string TELEFONO1 { get; set; }
        public string TELEFONO2 { get; set; }


        public Empresa empresa { get; set; }
        public Categorias categorias { get; set; }
        public T_Provincias t_Provincia { get; set; }

        public NivOrg NivelOrganizativo { get; set; }

        public Cuerpo Cuerpo { get; set; }
    }
}