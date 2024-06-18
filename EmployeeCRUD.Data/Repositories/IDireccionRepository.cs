using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public interface IDireccionRepository : IDisposable
    {
        Task<IEnumerable<Direccion>> GetDirecciones();
        Task<Direccion?> GetDireccionByID(int? id);
        Task InsertDireccion(Direccion Direccion);
        Task DeleteDireccion(int? id);
        void UpdateDireccion(Direccion Direccion);
        Task SaveAsync();
    }
}
