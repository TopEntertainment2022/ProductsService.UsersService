using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.AccessData
{
    public class TopEntertainmentDbContext : DbContext
    {
        public TopEntertainmentDbContext() { }

        public TopEntertainmentDbContext(DbContextOptions<TopEntertainmentDbContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Valoration> Valorations { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
    }
}
