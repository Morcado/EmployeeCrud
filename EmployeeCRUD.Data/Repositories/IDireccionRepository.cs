using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public interface IDireccionRepository : IDisposable
    {
        IEnumerable<Direccion> GetDirecciones();
        Direccion? GetDireccionByID(Guid id);
        void InsertDireccion(Direccion Direccion);
        void DeleteDireccion(Guid id);
        void UpdateDireccion(Direccion Direccion);
        void Save();
    }
}
