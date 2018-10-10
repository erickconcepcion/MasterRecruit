using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace MasterRecruit.DataModel
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidato> Candidatos{ get; set;}
        public virtual DbSet<Capacitacion> Capacitaciones { get; set;}
        public virtual DbSet<Competencia> Competencias { get; set;}
        public virtual DbSet<Departamento> Departamentos { get; set;}
        public virtual DbSet<Empleado> Empleados { get; set;}
        public virtual DbSet<Empresa> Empresas { get; set;}
        public virtual DbSet<Experiencia> Experiencias{ get; set;}
        public virtual DbSet<Idioma> Idiomas { get; set;}
        public virtual DbSet<IdiomaHablado> IdiomaHablados { get; set;}
        public virtual DbSet<Institucion> Instituciones { get; set;}
        public virtual DbSet<Oportunity> Oportunities { get; set;}
        public virtual DbSet<Persona> Personas { get; set;}
        public virtual DbSet<Puesto> Puestos { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Generate GUID
            builder.Entity<Candidato>().Property(p=>p.Id).ValueGeneratedOnAdd();
            builder.Entity<Capacitacion>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Competencia>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Departamento>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Empleado>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Empresa>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Experiencia>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Idioma>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<IdiomaHablado>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Institucion>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Oportunity>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Persona>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Puesto>().Property(p => p.Id).ValueGeneratedOnAdd();

            //Application rels
            



        }
    }
}
