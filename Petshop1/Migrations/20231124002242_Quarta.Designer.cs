﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Petshop1.Models;

#nullable disable

namespace Petshop1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231124002242_Quarta")]
    partial class Quarta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Petshop1.Models.Animal", b =>
                {
                    b.Property<int>("idAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAnimal"), 1L, 1);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("tipoAnimal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAnimal");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("Petshop1.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"), 1L, 1);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Petshop1.Models.Servico", b =>
                {
                    b.Property<int>("idServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idServico"), 1L, 1);

                    b.Property<string>("data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idAnimal")
                        .HasColumnType("int");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idTipoServico")
                        .HasColumnType("int");

                    b.Property<int>("qtde")
                        .HasColumnType("int");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real");

                    b.HasKey("idServico");

                    b.HasIndex("idAnimal");

                    b.HasIndex("idCliente");

                    b.HasIndex("idTipoServico");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("Petshop1.Models.TipoServico", b =>
                {
                    b.Property<int>("idTipoServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTipoServico"), 1L, 1);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("idTipoServico");

                    b.ToTable("TipoServicos");
                });

            modelBuilder.Entity("Petshop1.Models.Servico", b =>
                {
                    b.HasOne("Petshop1.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("idAnimal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petshop1.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petshop1.Models.TipoServico", "TipoServico")
                        .WithMany()
                        .HasForeignKey("idTipoServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Cliente");

                    b.Navigation("TipoServico");
                });
#pragma warning restore 612, 618
        }
    }
}