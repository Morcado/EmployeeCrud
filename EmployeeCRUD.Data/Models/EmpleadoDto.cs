using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int IdDireccion { get; set; }
        public int IdGradoEstudio { get; set; }
        public int IdTipoEmpleado { get; set; }
    }
}
