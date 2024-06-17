using EmployeeCRUD.Data.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUD.Data.Entities
{
    public class Direccion : ISoftDeleatable
    {
        [Key]
        public Guid Id { get; set; }
        public required string? Calle { get; set; }
        public required string? Numero { get; set; }
        public required int CP { get; set; }
        public required Guid IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public virtual Estado? Estado { get; set; }
        public required Guid IdEmpleado { get; set; }
        public virtual Empleado? Empleado { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOnUtc { get; set; }
    }
}
