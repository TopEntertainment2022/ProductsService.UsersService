using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopEntertainment.Domain.DTOs
{
    public class ValorationDto
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool Valoracion { get; set; }
    }
}
