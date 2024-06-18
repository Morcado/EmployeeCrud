using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Repositories
{
    public interface IEmpleadoRepository : IDisposable
    {
        Task<IEnumerable<Empleado>> GetEmpleados();
        Task<Empleado?> GetEmpleadoByID(int? id);
        Task InsertEmpleado(Empleado empleado);
        Task DeleteEmpleado(int? id);
        void UpdateEmpleado(Empleado empleado);
        Task SaveAsync();
    }
}
