using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Models
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public ICollection<TelefonoDto> Telefonos { get; set; } = [];
        public int IdDireccion { get; set; }
        public virtual DireccionDto? Direccion { get; set; }
        public int IdGradoEstudio { get; set; }
        public virtual GradoEstudio? GradoEstudio { get; set; }
        public int IdTipoEmpleado { get; set; }
        public virtual TipoEmpleado? TipoEmpleado { get; set; }
    }
}
