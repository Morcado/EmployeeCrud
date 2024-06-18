using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data.Repositories
{
    public class EmpleadoRepository(DataContext context) : IEmpleadoRepository, IDisposable
    {
        private readonly DataContext context = context;

        public async Task DeleteEmpleado(int? id)
        {
            Empleado? empleado = await context.Empleados.FindAsync(id);
            ArgumentNullException.ThrowIfNull(empleado, nameof(empleado));
            context.Empleados.Remove(empleado);
        }

        public async Task<Empleado?> GetEmpleadoByID(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var empleado = await context.Empleados.Where(d => d.Id == id).FirstOrDefaultAsync();
            return empleado;
        }

        public async Task<IEnumerable<Empleado>> GetEmpleados()
        {
            return await context.Empleados.ToListAsync();
        }

        public async Task InsertEmpleado(Empleado empleado)
        {
            ArgumentNullException.ThrowIfNull(empleado);

            //empleado.Id = int.Newint();
            await context.Empleados.AddAsync(empleado);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            // not implemented
        }

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~EmpleadoRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
