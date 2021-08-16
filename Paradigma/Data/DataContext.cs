using Microsoft.EntityFrameworkCore;
using Paradigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paradigma.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colaborador>().HasData(
                new Colaborador
                {
                    Id = 1,
                    Nome = "Joe",
                    Salario = 70000,
                    DepartamentoId = 1
                },
                new Colaborador
                {
                    Id = 2,
                    Nome = "Henry",
                    Salario = 80000,
                    DepartamentoId = 2

                },
                new Colaborador
                {
                    Id = 3,
                    Nome = "Sam",
                    Salario = 60000,
                    DepartamentoId = 2

                },
                new Colaborador
                {
                    Id = 4,
                    Nome = "Max",
                    Salario = 90000,
                    DepartamentoId = 1

                }
            );
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "TI" },
                new Departamento { Id = 2, Nome = "Vendas", }
            );
        }

    }
}
