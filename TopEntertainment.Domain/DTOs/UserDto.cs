using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        public bool SoftDelete { get; set; }
    }
}
