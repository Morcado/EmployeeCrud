using EmployeeCRUD.Data.Entities;

namespace EmployeeCRUD.Data.Models
{
    public class DireccionDto
    {
        public int Id { get; set; }
        public string? Calle { get; set; }
        public string? Numero { get; set; }
        public int CP { get; set; }
        public int IdEstado { get; set; }
        public Estado? Estado { get; set; }
        public int IdEmpleado { get; set; }
    }
}
