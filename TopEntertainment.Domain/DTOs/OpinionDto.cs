using System.ComponentModel.DataAnnotations;

namespace TopEntertainment.Domain.DTOs
{
    public class OpinionDto
    {
        [Required]
        public int OpinionId { get; set; }
        [Required]
        public int JuegoId { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
