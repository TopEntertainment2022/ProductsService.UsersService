using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopEntertainment.AccessData.Data
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext() { }

        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;UsuariosDb;Trusted_Connection=True;");
        }
    }
}
