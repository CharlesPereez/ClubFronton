using CRUDPersonas.Entities;
using CRUDPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly DBContext _context;
        public PersonaController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listPersonas = await _context.Personas.ToListAsync();
                return Ok(listPersonas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {

                var persona = await _context.Personas.FindAsync(id);
                if (persona == null)
                {
                    return NotFound();
                }
                return Ok(persona);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var persona = await _context.Personas.FindAsync(id);
                if (persona == null)
                {
                    return NotFound();
                }
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Persona persona)
        {
            try
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = persona.PersonaId }, persona );
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Persona persona)
        {
            try
            {
                if (id != persona.PersonaId)
                {
                    return BadRequest();
                }

                var personaItem = await _context.Personas.FindAsync(id);

                if (personaItem == null)
                {
                    return NotFound(); //404
                }

                personaItem.PersonaId = id;
                personaItem.CiPersona = persona.CiPersona;
                personaItem.Nombres = persona.Nombres;
                personaItem.Apellidos = persona.Apellidos;
                personaItem.Genero= persona.Genero;
                personaItem.FechaNacimiento = persona.FechaNacimiento;
                personaItem.Direccion= persona.Direccion;

                await _context.SaveChangesAsync();

                return Ok(personaItem);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
