﻿// <auto-generated />
using System;
using MasterRecruit.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasterRecruit.DataModel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181017001855_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasterRecruit.DataModel.Candidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("EmpleadoId");

                    b.Property<DateTime>("LastVisit");

                    b.Property<Guid>("OportunityId");

                    b.Property<Guid>("PersonaId");

                    b.Property<Guid>("PuestoId");

                    b.Property<decimal>("SalarioPropuesto");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("OportunityId")
                        .IsUnique();

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.HasIndex("PuestoId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Capacitacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CandidatoId");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("FechaDesde");

                    b.Property<DateTime>("FechaHasta");

                    b.Property<Guid>("InstitucionId");

                    b.Property<int>("Nivel");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("InstitucionId");

                    b.ToTable("Capacitaciones");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Competencia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CandidatoId");

                    b.Property<string>("Descripcion");

                    b.Property<bool>("Estado");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Departamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Empleado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("FechaIngreso");

                    b.Property<Guid>("PersonaId");

                    b.Property<Guid>("PuestoId");

                    b.Property<decimal>("Salario");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.HasIndex("PuestoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Experiencia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CandidatoId");

                    b.Property<Guid>("EmpresaId");

                    b.Property<DateTime>("FechaDesde");

                    b.Property<DateTime>("FechaHasta");

                    b.Property<string>("PuestoUsado");

                    b.Property<decimal>("Salario");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Idioma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Idiomas");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.IdiomaHablado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CandidatoId");

                    b.Property<Guid>("IdiomaId");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("IdiomaId");

                    b.ToTable("IdiomaHablados");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Institucion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Instituciones");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Oportunity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("Id");

                    b.ToTable("Oportunities");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Persona", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cedula");

                    b.Property<string>("Nombres");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Puesto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartamentoId");

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre");

                    b.Property<int>("Riezgo");

                    b.Property<decimal>("SueldoMaximo");

                    b.Property<decimal>("SueldoMinimo");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Candidato", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Empleado", "Empleado")
                        .WithMany("Candidatos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MasterRecruit.DataModel.Oportunity", "Oportunity")
                        .WithOne("Candidato")
                        .HasForeignKey("MasterRecruit.DataModel.Candidato", "OportunityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasterRecruit.DataModel.Persona", "Persona")
                        .WithOne("Candidato")
                        .HasForeignKey("MasterRecruit.DataModel.Candidato", "PersonaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MasterRecruit.DataModel.Puesto", "Puesto")
                        .WithMany("Candidatos")
                        .HasForeignKey("PuestoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Capacitacion", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Candidato", "Candidato")
                        .WithMany("Capacitaciones")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasterRecruit.DataModel.Institucion", "Institucion")
                        .WithMany("Capacitaciones")
                        .HasForeignKey("InstitucionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Competencia", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Candidato", "Candidato")
                        .WithMany("Competencias")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Empleado", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Persona", "Persona")
                        .WithOne("Empleado")
                        .HasForeignKey("MasterRecruit.DataModel.Empleado", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasterRecruit.DataModel.Puesto", "Puesto")
                        .WithMany("Empleados")
                        .HasForeignKey("PuestoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Experiencia", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Candidato", "Candidato")
                        .WithMany("Experiencias")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasterRecruit.DataModel.Empresa", "Empresa")
                        .WithMany("Experiencias")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.IdiomaHablado", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Candidato", "Candidato")
                        .WithMany("IdiomaHablados")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasterRecruit.DataModel.Idioma", "Idioma")
                        .WithMany("IdiomaHablados")
                        .HasForeignKey("IdiomaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MasterRecruit.DataModel.Puesto", b =>
                {
                    b.HasOne("MasterRecruit.DataModel.Departamento", "Departamento")
                        .WithMany("Puestos")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
