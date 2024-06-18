using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class GradoEstudio
    {
        [Key]
        public int Id { get; set; }
        public required string? Nombre { get; set; }
    }
}
