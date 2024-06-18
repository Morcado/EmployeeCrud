namespace EmployeeCRUD.Data.Models
{
    public class DireccionCreateDto
    {
        public required string? Calle { get; set; }
        public required string? Numero { get; set; }
        public required int CP { get; set; }
        public int? IdEstado { get; set; }
        public int? IdEmpleado { get; set; }
    }
}
