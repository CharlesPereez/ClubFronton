using System.ComponentModel.DataAnnotations;

namespace CRUDPersonas.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        public string Usuario { get; set; }
    }
}
