using EmployeeCRUD.Data.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Entities
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        public required string? Nombre { get; set; }
    }
}
