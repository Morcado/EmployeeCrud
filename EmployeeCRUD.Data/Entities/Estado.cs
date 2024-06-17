using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class Estado
    {
        [Key]
        public Guid Id { get; set; }
        public required string? Nombre { get; set; }
    }
}
