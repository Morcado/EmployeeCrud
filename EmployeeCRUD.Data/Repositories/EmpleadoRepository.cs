using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public class EmpleadoRepository(DataContext context) : IEmpleadoRepository, IDisposable
    {
        private readonly DataContext context = context;

        public void DeleteEmpleado(Guid id)
        {
            Empleado? empleado = context.Empleados.Find(id);
            ArgumentNullException.ThrowIfNull(empleado, nameof(empleado));
            context.Empleados.Remove(empleado);
        }

        public Empleado? GetEmpleadoByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var empleado = context.Empleados.Where(d => d.Id == id).FirstOrDefault();
            return empleado;
        }

        public IEnumerable<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }

        public void InsertEmpleado(Empleado empleado)
        {
            ArgumentNullException.ThrowIfNull(empleado);

            empleado.Id = Guid.NewGuid();
            context.Empleados.Add(empleado);
        }

        public void Save()
        {
            context.SaveChanges();
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
