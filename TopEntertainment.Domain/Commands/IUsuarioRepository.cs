using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IUsuarioRepository
    {
        List<User> GetAll();
        User GetUserById(int id);
    }
}
