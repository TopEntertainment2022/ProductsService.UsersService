using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IOpinionRepository
    {
        List<Opinion> GetAllOpinions();
        Opinion GetOpinionById(int id);
        void Add(Opinion opinion);
        void Delete(Opinion opinion);
    }
}
