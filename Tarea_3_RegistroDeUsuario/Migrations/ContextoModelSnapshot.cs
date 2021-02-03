﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea_3_RegistroDeUsuario.DAL;

namespace Tarea_3_RegistroDeUsuario.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Tarea_3_RegistroDeUsuario.Entidades.Roles", b =>
                {
                    b.Property<int>("rolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("rolesId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Tarea_3_RegistroDeUsuario.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RolesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolesId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Tarea_3_RegistroDeUsuario.Entidades.Usuarios", b =>
                {
                    b.HasOne("Tarea_3_RegistroDeUsuario.Entidades.Roles", "role")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("role");
                });
#pragma warning restore 612, 618
        }
    }
}
