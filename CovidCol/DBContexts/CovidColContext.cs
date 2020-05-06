using CovidCol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.DBContexts
{
    public class CovidColContext: DbContext
    {
        public CovidColContext(DbContextOptions<CovidColContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>().HasData(
                new TipoDocumento
                {
                    Id = 1,
                    Descripcion = "Cédula de ciudadanía",
                    Abreviacion = "CC"
                },
                new TipoDocumento
                {
                    Id = 2,
                    Descripcion = "Cédula de extranjería",
                    Abreviacion = "CE"
                },
                new TipoDocumento
                {
                    Id = 3,
                    Descripcion = "Tarjeta de Identidad",
                    Abreviacion = "TI"
                },
                new TipoDocumento
                {
                    Id = 4,
                    Descripcion = "Registro Civil",
                    Abreviacion = "RC"
                }
            );

            modelBuilder.Entity<Departamento>().HasData(
                new Departamento
                {
                    Id = 1,
                    Nombre = "Cundinamarca"
                },
                new Departamento
                {
                    Id = 2,
                    Nombre = "Boyacá"
                },
                new Departamento
                {
                    Id = 3,
                    Nombre = "Atlantico"
                },
                new Departamento
                {
                    Id = 4,
                    Nombre = "Antioquia"
                }
            );

            modelBuilder.Entity<Ciudad>().HasData(
                new Ciudad
                {
                    Id = 1,
                    NombreCiudad = "Bogotá",
                    DepartamentoId = 1
                },
                new Ciudad
                {
                    Id = 2,
                    NombreCiudad = "Tunja",
                    DepartamentoId = 2
                },
                new Ciudad
                {
                    Id = 3,
                    NombreCiudad = "Barranquilla",
                    DepartamentoId = 3
                },
                new Ciudad
                {
                    Id = 4,
                    NombreCiudad = "Medellín",
                    DepartamentoId = 4
                }
            );

        }
    }
}
