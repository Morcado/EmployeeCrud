using EmployeeCRUD.Data.DbContexts;
using EmployeeCRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data.Repositories
{
    public class TelefonoRepository(DataContext context) : ITelefonoRepository, IDisposable
    {
        private readonly DataContext context = context;

        public async Task DeleteTelefono(int? id)
        {
            Telefono? telefono = await context.Telefonos.FindAsync(id);
            ArgumentNullException.ThrowIfNull(telefono, nameof(telefono));
            context.Telefonos.Remove(telefono);
        }

        public async Task<Telefono?> GetTelefonoByID(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var telefono = await context.Telefonos.Where(d => d.Id == id).FirstOrDefaultAsync();
            return telefono;
        }

        public async Task<IEnumerable<Telefono>> GetTelefonos()
        {
            return await context.Telefonos.ToListAsync();
        }

        public async Task InsertTelefono(Telefono telefono)
        {
            ArgumentNullException.ThrowIfNull(telefono);

            await context.Telefonos.AddAsync(telefono);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void UpdateTelefono(Telefono telefono)
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
        // ~TelefonoRepository()
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
