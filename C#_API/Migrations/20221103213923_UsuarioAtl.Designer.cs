﻿// <auto-generated />
using System;
using C__API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C__API.Migrations
{
    [DbContext(typeof(UsuarioDbContext))]
    [Migration("20221103213923_UsuarioAtl")]
    partial class UsuarioAtl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("C__API.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("dataNacimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sobrenome");

                    b.Property<int>("telefone")
                        .HasColumnType("int")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
