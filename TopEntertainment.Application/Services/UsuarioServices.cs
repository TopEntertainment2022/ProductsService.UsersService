using AutoMapper;
using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Application.Services
{
    public interface IUsuarioService
    {
        List<User> GetAll();
        User GetUserById(int id);
        void Update(User usuario);
        void Delete(User usuario);
        User CreateUser(UserDto usuario);
    }
    public class UsuarioServices : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioServices(IUsuarioRepository usuarioRepository,
            IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        
        public List<User> GetAll()
        {
            return _usuarioRepository.GetAll();

        }

        public User GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }

        public User CreateUser(UserDto usuario)
        {
            var usuarioMapeado = _mapper.Map<User>(usuario);
            _usuarioRepository.Add(usuarioMapeado);

            return usuarioMapeado;
        }

        public void Update(User usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void Delete(User usuario)
        {
            _usuarioRepository.Delete(usuario);
        }


    }
}
