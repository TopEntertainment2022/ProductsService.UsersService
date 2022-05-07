using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopEntertainment.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        public int TipoDeUsuario { get; set; }
        [Required]
        public bool SoftDelete { get; set; }
    }
}
