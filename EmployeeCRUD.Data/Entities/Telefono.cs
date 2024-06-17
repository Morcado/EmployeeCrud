using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class Telefono
    {
        [Key]
        public Guid Id { get; set; }
        public required Guid IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; } = null!;
        public required int Numero { get; set; }
        public required int Extension { get; set; }
        public string? Tipo { get; set; } // mobil o particular
    }
}
