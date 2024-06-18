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
        public int? IdDireccion { get; set; }
        public int? IdGradoEstudio { get; set; }
        public int? IdTipoEmpleado { get; set; }
    }
}
