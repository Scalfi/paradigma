﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Paradigma.Data;

namespace Paradigma.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Paradigma.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("integer")
                        .HasColumnName("departamento_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("Salario")
                        .HasColumnType("numeric")
                        .HasColumnName("salario");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("colaborador");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentoId = 1,
                            Nome = "Joe",
                            Salario = 70000m
                        },
                        new
                        {
                            Id = 2,
                            DepartamentoId = 2,
                            Nome = "Henry",
                            Salario = 80000m
                        },
                        new
                        {
                            Id = 3,
                            DepartamentoId = 2,
                            Nome = "Sam",
                            Salario = 60000m
                        },
                        new
                        {
                            Id = 4,
                            DepartamentoId = 1,
                            Nome = "Max",
                            Salario = 90000m
                        });
                });

            modelBuilder.Entity("Paradigma.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("departamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "TI"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Vendas"
                        });
                });

            modelBuilder.Entity("Paradigma.Models.Colaborador", b =>
                {
                    b.HasOne("Paradigma.Models.Departamento", "GetDepartamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetDepartamento");
                });
#pragma warning restore 612, 618
        }
    }
}
