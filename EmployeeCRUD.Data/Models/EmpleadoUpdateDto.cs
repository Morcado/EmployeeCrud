using EmployeeCRUD.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Data.Models
{
    public class EmpleadoUpdateDto
    {
        public required string? Nombre { get; set; }
        public required string? ApellidoPaterno { get; set; }
        public required string? ApellidoMaterno { get; set; }
        public required int Edad { get; set; }
        public required char Genero { get; set; }
        public Guid? IdDireccion { get; set; }
        public Guid? IdGradoEstudio { get; set; }
        public Guid? IdTipoEmpleado { get; set; }
    }
}
