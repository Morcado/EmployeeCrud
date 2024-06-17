using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Data.Entities
{
    public class Empleado
    {
        [Key]
        public Guid Id { get; set; }
        public required int Nombre { get; set; }
        public required string? ApellidoPaterno { get; set; }
        public required string? ApellidoMaterno { get; set; }
        public required int Edad { get; set; }
        public required char Genero { get; set; } // m o f
        [ForeignKey(nameof(IdDireccion))]
        public virtual Direccion? Direccion { get; set; }
        public Guid IdDireccion { get; set; }
        public required ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
        [ForeignKey("IdGradoEstudio")]
        public virtual GradoEstudio? GradoEstudio { get; set; }
        public Guid IdGradoEstudio { get; set; }
        [ForeignKey("IdTipoEmpleado")]
        public virtual TipoEmpleado? TipoEmpleado { get; set; }
        public Guid IdTipoEmpleado { get; set; }
    }
}
