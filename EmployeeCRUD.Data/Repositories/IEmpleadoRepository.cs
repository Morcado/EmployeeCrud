using EmployeeCRUD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Data.Repositories
{
    public interface IEmpleadoRepository : IDisposable
    {
        IEnumerable<Empleado> GetEmpleados();
        Empleado? GetEmpleadoByID(Guid id);
        void InsertEmpleado(Empleado empleado);
        void DeleteEmpleado(Guid id);
        void UpdateEmpleado(Empleado empleado);
        void Save();
    }
}
