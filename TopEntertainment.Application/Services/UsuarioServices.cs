using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Application.Services
{
    public interface IUsuarioService
    {
        List<User> GetAll();
        User GetUserById(int id);
    }
    public class UsuarioServices : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<User> GetAll()
        {
            return _usuarioRepository.GetAll();
            
        }

        public User GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }
    }
}
