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
        public string DOMICILIO { get; set; }
        public string E_CIVIL { get; set; }
        public string EMAIL { get; set; }
        public string ES_FAMILIA_NUMEROSA { get; set; }
        public string ESCALERA { get; set; }
        public string F_ALTA { get; set; }
        public string F_BAJA { get; set; }
        public string F_NAC { get; set; }
        public string GCROWVER { get; set; }
        public string GRUPO { get; set; }
        public int HORAS_ANUAL { get; set; }
        public string HST_SIT_ADMV { get; set; }
        public int ID { get; set; }
        public int ID_CATEGORIA { get; set; }
        public int ID_EMPRESSA { get; set; }
        public int ID_HST_SIT_ADMV { get; set; }
        public int ID_NIVEL { get; set; }
        public int ID_ORGANIG { get; set; }
        public int ID_PAIS { get; set; }
        public int ID_PAIS_NAC { get; set; }
        public int ID_POBLACION { get; set; }
        public int ID_POBLACION_NAC { get; set; }
        public int ID_PROBINCIA { get; set; }
        public int ID_PROBINCIA_NAC { get; set; }
        public int ID_PUESTO { get; set; }
        public int ID_T_SIT_ADMV { get; set; }
        public int ID_TRABAJADOR { get; set; }
        public string MINUSV { get; set; }
        public string NIF { get; set; }
        public string NIV_ORG_ID { get; set; }
        public string NOMBRE { get; set; }
        public int NUM { get; set; }
        public string P_JORNADA_CTO { get; set; }
        public string P_JORNADA_TRAB { get; set; }
        public string P_OCUPACION { get; set; }
        public string P_REDUC_JORNADA { get; set; }
        public string PISO { get; set; }
        public string PUERTA { get; set; }
        public string RESIDENTE { get; set; }
        public string SEXO { get; set; }
        public string SIGLAS { get; set; }
        public string SIT_ADMV { get; set; }
        public string T_PROVIS { get; set; }
        public string TELEF_EMERG { get; set; }
        public string TELEFONO { get; set; }

        public Empresa empresa { get; set; }
        public Categorias categorias { get; set; }
        public T_Provincias t_Provincia { get; set; }
     
        public Cuerpo Cuerpo { get; set; }
    }
}