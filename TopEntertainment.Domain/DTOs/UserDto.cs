using System.ComponentModel.DataAnnotations;

namespace TopEntertainment.Domain.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        public int TipoDeUsuario { get; set; }
        public bool SoftDelete { get; set; }
    }
}
