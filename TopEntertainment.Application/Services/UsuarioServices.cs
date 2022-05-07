using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private readonly IUsuarioService _userService;

        public UsuarioServices(IUsuarioService userService)
        {
            _userService = userService;
        }

        public List<User> GetAll()
        {
            return _userService.GetAll();
            
        }

        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }
    }
}
