﻿// <auto-generated />
using System;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContexto))]
    partial class ClinicaVeterinariaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Raca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("especie");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("racas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especie = "Gato",
                            Nome = "Frajola"
                        },
                        new
                        {
                            Id = 2,
                            Especie = "Capivara",
                            Nome = "Piupiu"
                        });
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Crmv")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("VARCHAR(7)");

                    b.Property<bool>("Empregado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(true);

                    b.Property<int?>("Idade")
                        .HasColumnType("INT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<decimal?>("Salario")
                        .HasPrecision(9, 2)
                        .HasColumnType("DECIMAL(9,2)");

                    b.HasKey("Id");

                    b.ToTable("Veterinario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Crmv = "66666SC",
                            Empregado = false,
                            Nome = "Amanda"
                        },
                        new
                        {
                            Id = 2,
                            Crmv = "85641",
                            Empregado = false,
                            Nome = "Gui"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
