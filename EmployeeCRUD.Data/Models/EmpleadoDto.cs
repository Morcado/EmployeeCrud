using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Data.Models
{
    public class EmpleadoDto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public Guid IdDireccion { get; set; }
        public Guid IdGradoEstudio { get; set; }
        public Guid IdTipoEmpleado { get; set; }
    }
}
