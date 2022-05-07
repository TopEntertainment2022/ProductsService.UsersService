using Microsoft.EntityFrameworkCore;
using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.AccessData.Commands
{
    public class UsuariosRepository : IUsuarioRepository
    {
        private readonly TopEntertainmentDbContext _context;

        public UsuariosRepository(TopEntertainmentDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(User => User.UserId == id);
        }
    }
}
