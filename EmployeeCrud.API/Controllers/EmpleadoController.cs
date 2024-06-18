using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {   private readonly IEmpleadoRepository empleadoRepository;
        private readonly IMapper mapper;
        
        public EmpleadoController(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            this.empleadoRepository = empleadoRepository;
            this.mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetEmpleados()
        {
            var empleados = await empleadoRepository.GetEmpleados();
            return Ok(mapper.Map<EmpleadoDto[]>(empleados));
        }

        [HttpGet("{id}", Name = "GetEmpleado")]
        public async Task<IActionResult> GetEmpleadoById(int id)
        {
            var empleado = await empleadoRepository.GetEmpleadoByID(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<EmpleadoDto>(empleado));
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmpleado(EmpleadoCreateDto empleadoCreate)
        {
            var empleado = mapper.Map<Empleado>(empleadoCreate);
            await empleadoRepository.InsertEmpleado(empleado);
            await empleadoRepository.SaveAsync();

            return Created("GetEmpleado", mapper.Map<EmpleadoDto>(empleado));
            /*return CreatedAtRoute("GetEmpleado", new
            {
                IdEmpleado = empleadoReturn.Id
            },
            empleadoReturn);*/ 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmpleado(int id, EmpleadoUpdateDto empleadoUpdate)
        {
            var empleado = await empleadoRepository.GetEmpleadoByID(id);
            if (empleado == null)
            {
                return NotFound();
            }

            mapper.Map(empleadoUpdate, empleado);
            empleadoRepository.UpdateEmpleado(empleado);
            await empleadoRepository.SaveAsync();

            return NoContent();
        }


        [HttpDelete("{id}", Name = "GetEmpleado")]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            var empleados = await empleadoRepository.GetEmpleadoByID(id);
            if (empleados == null)
            {
                return NotFound();
            }

            await empleadoRepository.DeleteEmpleado(id);
            await empleadoRepository.SaveAsync();
            return NoContent();
        }
    }
    
}
