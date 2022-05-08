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
        User InsertUser(UserDto User);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
    public class UsuarioServices : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioServices(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public void DeleteUser(User user)
        {
            _usuarioRepository.DeleteUser(user);
        }
        public List<User> GetAll()
        {
            return _usuarioRepository.GetAll();
        }
        public User GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }
        public User InsertUser(UserDto User)
        {
            var usuarioMapeado = _mapper.Map<User>(User);
            _usuarioRepository.InsertUser(usuarioMapeado);
            return usuarioMapeado;
        }
        public void UpdateUser(User user)
        {
            _usuarioRepository.UpdateUser(user);  
        }
        //    public List<UserDto> GetAll()
        //    {
        //        var users=_usuarioRepository.GetAll();
        //        var usuarioMapped = _mapper.Map<List<UserDto>>(users);
        //        return usuarioMapped;

        //    }
    }
}
