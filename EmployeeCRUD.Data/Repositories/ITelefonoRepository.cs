using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public interface ITelefonoRepository : IDisposable
    {
        Task<IEnumerable<Telefono>> GetTelefonos();
        Task<Telefono?> GetTelefonoByID(int? id);
        Task InsertTelefono(Telefono Telefono);
        Task DeleteTelefono(int? id);
        void UpdateTelefono(Telefono Telefono);
        Task SaveAsync();
    }
}
