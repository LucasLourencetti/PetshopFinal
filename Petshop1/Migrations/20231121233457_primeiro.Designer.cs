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
    [Migration("20231121233457_primeiro")]
    partial class primeiro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
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
#pragma warning restore 612, 618
        }
    }
}
