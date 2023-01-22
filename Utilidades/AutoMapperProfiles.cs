using AutoMapper;
using CRUDPersonas.DTOs;
using CRUDPersonas.Entities;

namespace CRUDPersonas.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
        
            CreateMap<PersonaDTO,  Persona>();
            CreateMap<Persona,  PersonaDTO>();

        }
    }
}
