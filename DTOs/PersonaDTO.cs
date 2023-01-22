using System.ComponentModel.DataAnnotations;

namespace CRUDPersonas.DTOs
{
    public class PersonaDTO
    {
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe tener más de {1} caracteres")]
        public string? CiPersona { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Apellidos { get; set; }
        public string? Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
    }
}
