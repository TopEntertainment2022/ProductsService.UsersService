using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopEntertainment.Domain.DTOs
{
    public class OpinionCreatedDto
    {
        public int JuegoId { get; set; }
        public int UserId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
