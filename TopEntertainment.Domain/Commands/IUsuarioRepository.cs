using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IUsuarioRepository
    {
        List<User> GetAll();
        User GetUserById(int id);
        void Update(User user);
        void Delete(User user);
        void Add(User user);
    }
}
