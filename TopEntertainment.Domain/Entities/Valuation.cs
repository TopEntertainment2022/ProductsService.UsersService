using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopEntertainment.Domain.Entities
{
    public class Valuation
    {
        public int Id { get; set; }
        [ForeignKey("Producto")]
        public int ProductoId { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        [Required]
        public bool Valoracion { get; set; }
    }
}
