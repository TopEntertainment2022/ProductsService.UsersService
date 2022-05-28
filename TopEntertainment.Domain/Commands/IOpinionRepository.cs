using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IOpinionRepository
    {
        List<Opinion> GetAllOpinions();
        List<int> GetOpinionsByJuegoId(int id);
        Opinion GetOpinionById(int id);  
        void Add(Opinion opinion);
        void Update(Opinion opinion);
        void Delete(Opinion opinion);
    }
}
