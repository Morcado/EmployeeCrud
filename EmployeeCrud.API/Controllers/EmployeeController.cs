using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {   private readonly IEmpleadoRepository empleadoRepository;
        private readonly IMapper mapper;
        
        public EmployeeController(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            this.empleadoRepository = empleadoRepository;
            this.mapper = mapper;
        }

        [HttpGet()]
        public IActionResult GetEmpleados()
        {
            var empleados = empleadoRepository.GetEmpleados();
            return Ok(empleados);
        }

        [HttpGet("{id}", Name = "GetEmpleado")]
        public IActionResult GetEmpleadoById(Guid id)
        {
            var empleado = empleadoRepository.GetEmpleadoByID(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        [HttpPost]
        public IActionResult CreateEmpleado(EmpleadoCreateDto empleadoCreate)
        {
            var empleado = mapper.Map<Empleado>(empleadoCreate);
            empleadoRepository.InsertEmpleado(empleado);
            empleadoRepository.Save();

            var empleadoReturn = mapper.Map<EmpleadoDto>(empleado);

            return Created("GetEmpleado", empleadoReturn);
            /*return CreatedAtRoute("GetEmpleado", new
            {
                IdEmpleado = empleadoReturn.Id
            },
            empleadoReturn);*/ 
        }

        [HttpDelete("{id}", Name = "GetEmpleado")]
        public IActionResult DeleteEmpleado(Guid id)
        {
            var empleados = empleadoRepository.GetEmpleadoByID(id);
            if (empleados == null)
            {
                return NotFound();
            }

            empleadoRepository.DeleteEmpleado(id);
            empleadoRepository.Save();
            return NoContent();
        }
    }
    
}
