using EmployeeCRUD.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Data.Entities
{
    public class Empleado : ISoftDeleatable
    {
        [Key]
        public int Id { get; set; }
        public required string? Nombre { get; set; }
        public required string? ApellidoPaterno { get; set; }
        public required string? ApellidoMaterno { get; set; }
        public required int Edad { get; set; }
        public required char Genero { get; set; } // m o f
        [ForeignKey(nameof(IdDireccion))]
        public virtual Direccion? Direccion { get; set; }
        public int? IdDireccion { get; set; }
        public ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
        [ForeignKey("IdGradoEstudio")]
        public virtual GradoEstudio? GradoEstudio { get; set; }
        public int? IdGradoEstudio { get; set; }
        [ForeignKey("IdTipoEmpleado")]
        public virtual TipoEmpleado? TipoEmpleado { get; set; }
        public int? IdTipoEmpleado { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOnUtc { get; set; }
    }
}
