﻿namespace EmployeeCRUD.Data.Models
{
    public class TelefonoCreateDto
    {
        public int IdEmpleado { get; set; }
        public int Numero { get; set; }
        public int Extension { get; set; }
        public string? Tipo { get; set; } // mobil o particular
    }
}
