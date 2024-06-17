using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public class DireccionRepository(DataContext context) : IDireccionRepository, IDisposable
    {
        private readonly DataContext context = context;

        public void DeleteDireccion(Guid id)
        {
            Direccion? Direccion = context.Direcciones.Find(id);
            ArgumentNullException.ThrowIfNull(Direccion, nameof(Direccion));
            context.Direcciones.Remove(Direccion);
        }

        public Direccion? GetDireccionByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return context.Direcciones.Where(d => d.Id == id).FirstOrDefault();
        }

        public IEnumerable<Direccion> GetDirecciones()
        {
            return [.. context.Direcciones];
        }

        public void InsertDireccion(Direccion Direccion)
        {
            ArgumentNullException.ThrowIfNull(Direccion);

            Direccion.Id = Guid.NewGuid();
            context.Add(Direccion);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateDireccion(Direccion Direccion)
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
        // ~DireccionRepository()
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
