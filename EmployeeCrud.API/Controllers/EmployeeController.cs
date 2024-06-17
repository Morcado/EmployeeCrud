using AutoMapper;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {   private readonly IEmpleadoRepository empleadoRepository;
        
        public EmployeeController(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
            //this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEmpleados()
        {
            var empleados = empleadoRepository.GetEmpleados();
            return Ok(empleados);
        }
    }
    
}
