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

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}