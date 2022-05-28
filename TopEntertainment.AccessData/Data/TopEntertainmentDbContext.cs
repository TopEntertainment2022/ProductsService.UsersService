using Microsoft.EntityFrameworkCore;
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
        //public virtual DbSet<Valoration> Valorations { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
    }
}
