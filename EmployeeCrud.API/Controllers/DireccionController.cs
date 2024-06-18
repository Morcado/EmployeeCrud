using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DireccionCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class DireccionController : ControllerBase
    {   private readonly IDireccionRepository DireccionRepository;
        private readonly IMapper mapper;
        
        public DireccionController(IDireccionRepository DireccionRepository, IMapper mapper)
        {
            this.DireccionRepository = DireccionRepository;
            this.mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetDireccions()
        {
            var direcciones = await DireccionRepository.GetDirecciones();
            return Ok(mapper.Map<DireccionDto[]>(direcciones));
        }

        [HttpGet("{id}", Name = "GetDireccion")]
        public async Task<IActionResult> GetDireccionById(int id)
        {
            var direccion = await DireccionRepository.GetDireccionByID(id);
            if (direccion == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<DireccionDto>(direccion));
        }

        [HttpPost]
        public async Task<IActionResult> CreateDireccion(DireccionCreateDto DireccionCreate)
        {
            var direccion = mapper.Map<Direccion>(DireccionCreate);
            await DireccionRepository.InsertDireccion(direccion);
            await DireccionRepository.SaveAsync();

            return Created("GetDireccion", mapper.Map<DireccionDto>(direccion));
            /*return CreatedAtRoute("GetDireccion", new
            {
                IdDireccion = DireccionReturn.Id
            },
            DireccionReturn);*/ 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDireccion(int id, DireccionUpdateDto DireccionUpdate)
        {
            var direccion = await DireccionRepository.GetDireccionByID(id);
            if (direccion == null)
            {
                return NotFound();
            }

            mapper.Map(DireccionUpdate, direccion);
            DireccionRepository.UpdateDireccion(direccion);
            await DireccionRepository.SaveAsync();

            return NoContent();
        }


        [HttpDelete("{id}", Name = "GetDireccion")]
        public async Task<IActionResult> DeleteDireccion(int id)
        {
            var direccion = await DireccionRepository.GetDireccionByID(id);
            if (direccion == null)
            {
                return NotFound();
            }

            await DireccionRepository.DeleteDireccion(id);
            await DireccionRepository.SaveAsync();
            return NoContent();
        }
    }
    
}
