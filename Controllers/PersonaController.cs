using AutoMapper;
using CRUDPersonas.DTOs;
using CRUDPersonas.Entities;
using CRUDPersonas.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CRUDPersonas.Controllers
{
    [ApiController]
    [Route("api/persona")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]

    public class PersonaController : ControllerBase
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        

        public PersonaController(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listPersonas = await _context.Personas.ToListAsync();
                var listPersonaDto = _mapper.Map<IEnumerable<PersonaDTO>>(listPersonas);

                return Ok(listPersonaDto);
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

                var personaDto = _mapper.Map<PersonaDTO>(persona);

                return Ok(personaDto);
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
        public async Task<IActionResult> Post(PersonaDTO personaDto)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                
                _context.Add(persona);
                await _context.SaveChangesAsync();

                var personaItemDto = _mapper.Map<PersonaDTO>(persona);

                return CreatedAtAction("Get", new { id = personaItemDto.PersonaId }, personaItemDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PersonaDTO personaDto)
        {
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);


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
                personaItem.Genero = persona.Genero;
                personaItem.FechaNacimiento = persona.FechaNacimiento;
                personaItem.Direccion= persona.Direccion;

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
