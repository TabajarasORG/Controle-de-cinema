﻿// <auto-generated />
using System;
using ControleDeCinema.Infra.Orm.Conpartihado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDeCinema.Infra.Orm.Migrations
{
    [DbContext(typeof(ControleDeCinemaDbContext))]
    partial class ControleDeCinemaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleDeCinema.Dominio.ModuloFilme.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("ControleDeCinema.Dominio.ModuloSala.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TBSala", (string)null);
                });

            modelBuilder.Entity("ControleDeCinema.Dominio.ModuloSessao.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Filme_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("HorarioDeInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sala_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Filme_Id");

                    b.HasIndex("Sala_Id");

                    b.ToTable("TBSessao", (string)null);
                });

            modelBuilder.Entity("ControleDeCinema.Dominio.ModuloSessao.Sessao", b =>
                {
                    b.HasOne("ControleDeCinema.Dominio.ModuloFilme.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("Filme_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TBSessao_TBFilme");

                    b.HasOne("ControleDeCinema.Dominio.ModuloSala.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("Sala_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TBSessao_TBSala");

                    b.Navigation("Filme");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}