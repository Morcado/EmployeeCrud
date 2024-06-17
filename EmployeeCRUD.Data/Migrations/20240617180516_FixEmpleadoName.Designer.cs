﻿// <auto-generated />
using System;
using EmployeeCRUD.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeCRUD.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240617180516_FixEmpleadoName")]
    partial class FixEmpleadoName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Direccion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CP")
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEstado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Empleado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<Guid>("IdDireccion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGradoEstudio")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDireccion")
                        .IsUnique();

                    b.HasIndex("IdGradoEstudio");

                    b.HasIndex("IdTipoEmpleado");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.GradoEstudio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GradoEstudio");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Telefono", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Extension")
                        .HasColumnType("int");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Telefono");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.TipoEmpleado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoEmpleado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Direccion", b =>
                {
                    b.HasOne("EmployeeCRUD.Data.Entities.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Empleado", b =>
                {
                    b.HasOne("EmployeeCRUD.Data.Entities.Direccion", "Direccion")
                        .WithOne("Empleado")
                        .HasForeignKey("EmployeeCRUD.Data.Entities.Empleado", "IdDireccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeCRUD.Data.Entities.GradoEstudio", "GradoEstudio")
                        .WithMany()
                        .HasForeignKey("IdGradoEstudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeCRUD.Data.Entities.TipoEmpleado", "TipoEmpleado")
                        .WithMany()
                        .HasForeignKey("IdTipoEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");

                    b.Navigation("GradoEstudio");

                    b.Navigation("TipoEmpleado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Telefono", b =>
                {
                    b.HasOne("EmployeeCRUD.Data.Entities.Empleado", "Empleado")
                        .WithMany("Telefonos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Direccion", b =>
                {
                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("EmployeeCRUD.Data.Entities.Empleado", b =>
                {
                    b.Navigation("Telefonos");
                });
#pragma warning restore 612, 618
        }
    }
}
