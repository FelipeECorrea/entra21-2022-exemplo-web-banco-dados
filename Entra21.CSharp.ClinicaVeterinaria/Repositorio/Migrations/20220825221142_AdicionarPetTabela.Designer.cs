// <auto-generated />
using System;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContexto))]
    [Migration("20220825161142_AdicionarPetTabela")]
    partial class AdicionarPetTabela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<byte>("Tipo")
                        .HasColumnType("TINYINT")
                        .HasColumnName("tipo");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("contatos", (string)null);
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Altura")
                        .HasPrecision(3, 2)
                        .HasColumnType("DECIMAL(3,2)")
                        .HasColumnName("altura");

                    b.Property<byte>("Genero")
                        .HasColumnType("TINYINT")
                        .HasColumnName("genero");

                    b.Property<byte>("Idade")
                        .HasColumnType("TINYINT")
                        .HasColumnName("idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Peso")
                        .HasPrecision(5, 2)
                        .HasColumnType("DECIMAL(5,2)")
                        .HasColumnName("peso");

                    b.Property<int>("RacaId")
                        .HasColumnType("INT")
                        .HasColumnName("raca_id");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("INT")
                        .HasColumnName("responsavel_id");

                    b.HasKey("Id");

                    b.HasIndex("RacaId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("pets", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Altura = 0.90m,
                            Genero = (byte)1,
                            Idade = (byte)8,
                            Nome = "Mimi",
                            Peso = 20.40m,
                            RacaId = 1,
                            ResponsavelId = 1
                        });
                });

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
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

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

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<byte>("Idade")
                        .HasColumnType("TINYINT")
                        .HasColumnName("idade");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("nome_completo");

                    b.HasKey("Id");

                    b.ToTable("responsavies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "123.456.789-12",
                            Idade = (byte)20,
                            NomeCompleto = "Francisco"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "234.567.890-12",
                            Idade = (byte)21,
                            NomeCompleto = "Lucas"
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

                    b.ToTable("veterinarios", (string)null);

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
                            Crmv = "89898SC",
                            Empregado = false,
                            Nome = "Gui"
                        });
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Contato", b =>
                {
                    b.HasOne("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Responsavel", "Responsavel")
                        .WithMany("Contatos")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Pet", b =>
                {
                    b.HasOne("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Raca", "Raca")
                        .WithMany("Pets")
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Responsavel", "Responsavel")
                        .WithMany("Pets")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Raca", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Responsavel", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
