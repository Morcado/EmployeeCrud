using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data.Repositories
{
    public class DireccionRepository(DataContext context) : IDireccionRepository, IDisposable
    {
        private readonly DataContext context = context;

        public async Task DeleteDireccion(int? id)
        {
            Direccion? Direccion = await context.Direcciones.FindAsync(id);
            ArgumentNullException.ThrowIfNull(Direccion, nameof(Direccion));
            context.Direcciones.Remove(Direccion);
        }

        public async Task<Direccion?> GetDireccionByID(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var Direccion = await context.Direcciones.Where(d => d.Id == id).FirstOrDefaultAsync();
            return Direccion;
        }

        public async Task<IEnumerable<Direccion>> GetDirecciones()
        {
            return await context.Direcciones.ToListAsync();
        }

        public async Task InsertDireccion(Direccion Direccion)
        {
            ArgumentNullException.ThrowIfNull(Direccion);

            //Direccion.Id = int.Newint();
            await context.Direcciones.AddAsync(Direccion);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
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
