using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Categorias> Categors { get; set; }
        public virtual DbSet<Clase_Persona> Proveedores { get; set; }
        public virtual DbSet<Cuerpo> Suministros { get; set; }
        public virtual DbSet<Empresa> UserInfo { get; set; }
        public virtual DbSet<T_Provincias> Piezas { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>().HasKey(p => p.CATEGORI);
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.ToTable("Categors");
                entity.Property(p => p.CATEGORI)
                        .HasColumnName("CATEGORI")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.DESCRIP)
                        .HasColumnName("DESCRIP")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false);
                entity.Property(p => p.CUERPO)
                        .HasColumnName("CUERPO")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_CLASE_PER)
                         .HasColumnName("ID_CLASE_PER")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.ID_SUBESCALA)
                        .HasColumnName("ID_SUBESCALA")
                        .HasMaxLength(4)
                        .IsUnicode(false);
                entity.Property(p => p.ID_CLASE)
                        .HasColumnName("ID_CLASE")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_CLASE)
                        .HasColumnName("ID_CLASE")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_CLASE)
                        .HasColumnName("ID_CLASE")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.F_INI_VIGEN)
                        .HasColumnName("F_INI_VIGEN")
                        .IsUnicode(false);
                entity.Property(p => p.F_FIN_VIGEN)
                        .HasColumnName("F_FIN_VIGEN")
                        .IsUnicode(false);
                entity.Property(p => p.D_FUNCIONES)
                        .HasColumnName("D_FUNCIONES")
                        .HasMaxLength(200)
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.OBSERVAC)
                        .HasColumnName("OBSERVAC")
                        .HasMaxLength(60)
                        .IsUnicode(false);

            });

            modelBuilder.Entity<Clase_Persona>().HasKey(p => p.ID_CLASE_PER);
            modelBuilder.Entity<Clase_Persona>(entity =>
            {
                entity.ToTable("CLASE_PER");
                entity.Property(p => p.ID_CLASE_PER)
                        .HasColumnName("ID_CLASE_PER")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.D_CLASE_PER)
                        .HasColumnName("D_CLASE_PER")
                        .IsRequired()
                        .HasMaxLength(35)
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.ASIMILADO)
                        .HasColumnName("ASIMILADO")
                        .HasMaxLength(1)
                        .IsUnicode(false);
            });

            modelBuilder.Entity<Cuerpo>().HasKey(p => p.CUERPO);
            modelBuilder.Entity<Cuerpo>(entity =>
            {
                entity.ToTable("CUERPOS");
                entity.Property(p => p.CUERPO)
                        .HasColumnName("CUERPO")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.DESCRIP)
                        .HasColumnName("DESCRIP")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false);
                entity.Property(p => p.CATEGOR)
                        .HasColumnName("CATEGOR")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>().HasKey(p => p.ID_EMPRESA);
            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("EMPRESAS");
                entity.Property(p => p.ID_EMPRESA)
                        .HasColumnName("ID_EMPRESA")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.D_EMPRESA)
                        .HasColumnName("D_EMPRESA")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false);
                entity.Property(p => p.SIGLAS)
                        .HasColumnName("SIGLAS")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.DOMICILIO)
                        .HasColumnName("DOMICILIO")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false);
                entity.Property(p => p.NUM)
                        .HasColumnName("NUM")
                        .HasMaxLength(8)
                        .IsUnicode(false);
                entity.Property(p => p.KM)
                        .HasColumnName("KM")
                        .HasMaxLength(4)
                        .IsUnicode(false);
                entity.Property(p => p.ESCALERA)
                        .HasColumnName("ESCALERA")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.PISO)
                        .HasColumnName("PISO")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.PUERTA)
                        .HasColumnName("PUERTA")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.CPOSTAL)
                        .HasColumnName("CPOSTAL")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PROVINCIA)
                        .HasColumnName("ID_PROVINCIA")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_POBLACION)
                        .HasColumnName("ID_POBLACION")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.TELEFONO1)
                        .HasColumnName("TELEFONO1")
                        .HasMaxLength(15)
                        .IsUnicode(false);
                entity.Property(p => p.TELEFONO2)
                        .HasColumnName("TELEFONO2")
                        .HasMaxLength(15)
                        .IsUnicode(false);
                entity.Property(p => p.NIF)
                        .HasColumnName("NIF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
            });

            modelBuilder.Entity<T_Provincias>().HasKey(p => p.T_PROVIS);
            modelBuilder.Entity<T_Provincias>(entity =>
            {
                entity.ToTable("T_PROVIS");
                entity.Property(p => p.T_PROVIS)
                        .HasColumnName("T_PROVIS")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.DESCRIP)
                        .HasColumnName("DESCRIP")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false);
                entity.Property(p => p.ID_CLASE_PER)
                        .HasColumnName("ID_CLASE_PER")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
            });

            //multiples Primary Keys([ID_EMPRESA] , [ID_TRABAJADOR], [ID_ORGANIG], [ID_NIVEL]   )
            modelBuilder.Entity<Trabajadores>().HasKey(p => new { p.ID_EMPRESSA, p.ID_TRABAJADOR, p.ID_ORGANIG, p.ID_NIVEL });
            modelBuilder.Entity<Trabajadores>(entity =>
            {
                entity.ToTable("TRABAJADORES");
                entity.Property(p => p.APELLIDO1)
                        .HasColumnName("APELLIDO1")
                        .HasMaxLength(20)
                        .IsUnicode(false);
                entity.Property(p => p.APELLIDO2)
                        .HasColumnName("APELLIDO2")
                        .HasMaxLength(20)
                        .IsUnicode(false);
                entity.Property(p => p.CPOSTAL)
                        .HasColumnName("CPOSTAL")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.CUERPO)
                        .HasColumnName("CUERPO")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.DOMICILIO)
                        .HasColumnName("DOMICILIO")
                        .HasMaxLength(60)
                        .IsUnicode(false);
                entity.Property(p => p.E_CIVIL)
                        .HasColumnName("E_CIVIL")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.EMAIL)
                        .HasColumnName("EMAIL")
                        .HasMaxLength(64)
                        .IsUnicode(false);
                entity.Property(p => p.ES_FAMILIA_NUMEROSA)
                        .HasColumnName("ES_FAMILIA_NUMEROSA")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.ESCALERA)
                        .HasColumnName("ESCALERA")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.F_ALTA)
                        .HasColumnName("F_ALTA")
                        .IsUnicode(false);
                entity.Property(p => p.F_BAJA)
                        .HasColumnName("F_BAJA")
                        .IsUnicode(false);
                entity.Property(p => p.F_NAC)
                        .HasColumnName("F_NAC")
                        .IsUnicode(false);
                entity.Property(p => p.GCROWVER)
                        .HasColumnName("GCROWVER")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.GRUPO)
                        .HasColumnName("GRUPO")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.HORAS_ANUAL)
                        .HasColumnName("HORAS_ANUAL")                        
                        .IsUnicode(false);
                entity.Property(p => p.HST_SIT_ADMV)
                        .HasColumnName("HST_SIT_ADMV")
                        .IsUnicode(false);
                entity.Property(p => p.ID)
                        .HasColumnName("ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.ID_CATEGORIA)
                        .HasColumnName("ID_CATEGORIA")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_EMPRESSA)
                        .HasColumnName("ID_EMPRESSA")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_HST_SIT_ADMV)
                        .HasColumnName("ID_HST_SIT_ADMV")
                        .IsUnicode(false);
                entity.Property(p => p.ID_NIVEL)
                        .HasColumnName("ID_NIVEL")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_ORGANIG)
                        .HasColumnName("ID_ORGANIG")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PAIS)
                        .HasColumnName("ID_PAIS")
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PAIS_NAC)
                        .HasColumnName("ID_PAIS_NAC")
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.ID_POBLACION)
                        .HasColumnName("ID_POBLACION")
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.ID_POBLACION_NAC)
                        .HasColumnName("ID_POBLACION_NAC")
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PROBINCIA)
                        .HasColumnName("ID_PROBINCIA")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PROBINCIA_NAC)
                        .HasColumnName("ID_PROBINCIA_NAC")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_PUESTO)
                        .HasColumnName("ID_PUESTO")
                        .HasMaxLength(5)
                        .IsUnicode(false);
                entity.Property(p => p.ID_T_SIT_ADMV)
                        .HasColumnName("ID_T_SIT_ADMV")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.ID_TRABAJADOR)
                        .HasColumnName("ID_TRABAJADOR")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);
                entity.Property(p => p.MINUSV)
                        .HasColumnName("MINUSV")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.NIF)
                        .HasColumnName("NIF")
                        .HasMaxLength(14)
                        .IsUnicode(false);
                entity.Property(p => p.NIF)
                        .HasColumnName("NIF")
                        .HasMaxLength(14)
                        .IsUnicode(false);
                entity.Property(p => p.NIV_ORG_ID)
                        .HasColumnName("NIV_ORG_ID")
                        .IsRequired()
                        .IsUnicode(false);
                entity.Property(p => p.NOMBRE)
                        .HasColumnName("NOMBRE")
                        .HasMaxLength(20)
                        .IsUnicode(false);
                entity.Property(p => p.NUM)
                        .HasColumnName("NUM")
                        .HasMaxLength(8)
                        .IsUnicode(false);
                entity.Property(p => p.P_JORNADA_CTO)
                        .HasColumnName("P_JORNADA_CTO")
                        .IsUnicode(false);
                entity.Property(p => p.P_JORNADA_TRAB)
                        .HasColumnName("P_JORNADA_TRAB")
                        .IsUnicode(false);
                entity.Property(p => p.P_OCUPACION)
                        .HasColumnName("P_OCUPACION")
                        .IsUnicode(false);
                entity.Property(p => p.P_REDUC_JORNADA)
                        .HasColumnName("P_REDUC_JORNADA")
                        .IsUnicode(false);
                entity.Property(p => p.PISO)
                        .HasColumnName("PISO")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.PUERTA)
                        .HasColumnName("PUERTA")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.RESIDENTE)
                        .HasColumnName("RESIDENTE")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.SEXO)
                        .HasColumnName("SEXO")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.SEXO)
                        .HasColumnName("SEXO")
                        .HasMaxLength(1)
                        .IsUnicode(false);
                entity.Property(p => p.SIGLAS)
                        .HasColumnName("SIGLAS")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.SIT_ADMV)
                        .HasColumnName("SIT_ADMV")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false);
                entity.Property(p => p.T_PROVIS)
                        .HasColumnName("T_PROVIS")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);
                entity.Property(p => p.TELEF_EMERG)
                        .HasColumnName("TELEF_EMERG")
                        .HasMaxLength(15)
                        .IsUnicode(false);
                entity.Property(p => p.TELEFONO1)
                        .HasColumnName("TELEFONO1")
                        .HasMaxLength(15)
                        .IsUnicode(false);
                entity.Property(p => p.TELEFONO2)
                        .HasColumnName("TELEFONO2")
                        .HasMaxLength(15)
                        .IsUnicode(false);
            });

        }
    }
}

