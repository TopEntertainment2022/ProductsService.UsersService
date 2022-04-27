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
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
