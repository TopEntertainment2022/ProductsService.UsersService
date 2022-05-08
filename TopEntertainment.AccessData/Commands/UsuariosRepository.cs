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
        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);

            _context.SaveChanges();
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(User => User.UserId == id);
        }
        public void InsertUser(User User)
        {
            _context.Users.Add(User);

            _context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            _context.Users.Update(user);

            _context.SaveChanges(true);
        }
    }
}
