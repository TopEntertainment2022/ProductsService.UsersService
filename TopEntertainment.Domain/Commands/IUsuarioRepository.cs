using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IUsuarioRepository
    {
        List<User> GetAll();
        User GetUserById(int id);
    }
}
