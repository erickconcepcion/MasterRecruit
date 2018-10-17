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
            //Candidato
            builder.Entity<Candidato>().HasOne(p => p.Puesto).WithMany(p=>p.Candidatos).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Candidato>().HasOne(p => p.Persona).WithOne(p => p.Candidato).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Candidato>().HasOne(p => p.Oportunity).WithOne(p => p.Candidato).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Candidato>().HasOne(p => p.Empleado).WithMany(p => p.Candidatos).OnDelete(DeleteBehavior.SetNull);

            //Capacitacion
            builder.Entity<Capacitacion>().HasOne(p => p.Candidato).WithMany(p => p.Capacitaciones).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Capacitacion>().HasOne(p => p.Institucion).WithMany(p => p.Capacitaciones).OnDelete(DeleteBehavior.Restrict);

            //Competencia
            builder.Entity<Competencia>().HasOne(p => p.Candidato).WithMany(p => p.Competencias).OnDelete(DeleteBehavior.Cascade);

            //Empleados
            builder.Entity<Empleado>().HasOne(p => p.Puesto).WithMany(p => p.Empleados).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Empleado>().HasOne(p => p.Persona).WithOne(p => p.Empleado).OnDelete(DeleteBehavior.Cascade);

            //Experiencia
            builder.Entity<Experiencia>().HasOne(p => p.Candidato).WithMany(p => p.Experiencias).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Experiencia>().HasOne(p => p.Empresa).WithMany(p => p.Experiencias).OnDelete(DeleteBehavior.Restrict);

            //Idioma Hablado
            builder.Entity<IdiomaHablado>().HasOne(p => p.Candidato).WithMany(p => p.IdiomaHablados).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<IdiomaHablado>().HasOne(p => p.Idioma).WithMany(p => p.IdiomaHablados).OnDelete(DeleteBehavior.Cascade);

            //Puesto
            builder.Entity<Puesto>().HasOne(p => p.Departamento).WithMany(p => p.Puestos)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
