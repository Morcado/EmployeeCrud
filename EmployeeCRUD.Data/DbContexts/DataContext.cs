using EmployeeCRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data.DbContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
    }
}
