using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;
using EmployeeCRUD.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class TelefonoController : ControllerBase
    {   private readonly ITelefonoRepository telefonoRepository;
        private readonly IMapper mapper;
        
        public TelefonoController(ITelefonoRepository telefonoRepository, IMapper mapper)
        {
            this.telefonoRepository = telefonoRepository;
            this.mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetTelefonos()
        {
            var telefonos = await telefonoRepository.GetTelefonos();
            return Ok(mapper.Map<TelefonoDto[]>(telefonos));
        }

        [HttpGet("{id}", Name = "GetTelefono")]
        public async Task<IActionResult> GetTelefonoById(int id)
        {
            var telefono = await telefonoRepository.GetTelefonoByID(id);
            if (telefono == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<TelefonoDto>(telefono));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTelefono(TelefonoCreateDto telefonoCreate)
        {
            var telefono = mapper.Map<Telefono>(telefonoCreate);
            await telefonoRepository.InsertTelefono(telefono);
            await telefonoRepository.SaveAsync();

            return Created("GetTelefono", mapper.Map<TelefonoDto>(telefono));
            /*return CreatedAtRoute("GetTelefono", new
            {
                IdTelefono = telefonoReturn.Id
            },
            telefonoReturn);*/ 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTelefono(int id, TelefonoUpdateDto telefonoUpdate)
        {
            var telefono = await telefonoRepository.GetTelefonoByID(id);
            if (telefono == null)
            {
                return NotFound();
            }

            mapper.Map(telefonoUpdate, telefono);
            telefonoRepository.UpdateTelefono(telefono);
            await telefonoRepository.SaveAsync();

            return NoContent();
        }


        [HttpDelete("{id}", Name = "GetTelefono")]
        public async Task<IActionResult> DeleteTelefono(int id)
        {
            var telefonos = await telefonoRepository.GetTelefonoByID(id);
            if (telefonos == null)
            {
                return NotFound();
            }

            await telefonoRepository.DeleteTelefono(id);
            await telefonoRepository.SaveAsync();
            return NoContent();
        }
    }
    
}
