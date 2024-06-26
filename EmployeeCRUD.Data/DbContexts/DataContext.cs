﻿using EmployeeCRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data.DbContexts
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Telefono>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Direccion>().HasQueryFilter(e => !e.IsDeleted);
            
            modelBuilder.Entity<Empleado>().HasIndex(r => r.IsDeleted).HasFilter("IsDeleted = 0");
            modelBuilder.Entity<Telefono>().HasIndex(r => r.IsDeleted).HasFilter("IsDeleted = 0");
            modelBuilder.Entity<Direccion>().HasIndex(r => r.IsDeleted).HasFilter("IsDeleted = 0");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<GradoEstudio> GradoEstudio { get; set; }
        public DbSet<TipoEmpleado> TipoEmpleado { get; set; }
    }
}
