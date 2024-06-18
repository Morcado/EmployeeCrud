using EmployeeCRUD.Data.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class Telefono : ISoftDeleatable
    {
        [Key]
        public int Id { get; set; }
        public required int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; } = null!;
        public required int Numero { get; set; }
        public required int Extension { get; set; }
        public string? Tipo { get; set; } // mobil o particular
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOnUtc { get; set; }
    }
}
