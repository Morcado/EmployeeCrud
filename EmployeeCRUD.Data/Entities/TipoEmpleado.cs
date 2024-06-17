using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class TipoEmpleado
    {
        [Key]
        public Guid Id { get; set; }
        public required string? Nombre { get; set; }
    }
}
