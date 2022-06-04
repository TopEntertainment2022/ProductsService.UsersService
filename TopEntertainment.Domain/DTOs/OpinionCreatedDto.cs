using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopEntertainment.Domain.DTOs
{
    public class OpinionCreatedDto
    {
        [Required]
        public int JuegoId { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
