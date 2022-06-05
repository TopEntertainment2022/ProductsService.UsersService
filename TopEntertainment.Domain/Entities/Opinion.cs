using System.ComponentModel.DataAnnotations;

namespace TopEntertainment.Domain.Entities
{
    public class Opinion
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
        public virtual User User { get; set; }
    }
}
