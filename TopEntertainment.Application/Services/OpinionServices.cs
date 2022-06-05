using AutoMapper;
using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Application.Services
{
    public interface IOpinionService
    {
        List<Opinion> GetAllOpinions();
        Opinion GetOpinionById(int id);
        void AddOpinion(Opinion opinion);
        void Delete(Opinion opinion);
    }
    public class OpinionServices : IOpinionService
    {
        private readonly IOpinionRepository _OpinionRepository;
        public OpinionServices(IOpinionRepository iOpinionRepository)
        {
            _OpinionRepository = iOpinionRepository;
        }

        public void AddOpinion(Opinion opinion)
        {
            _OpinionRepository.Add(opinion);
        }

        public void Delete(Opinion opinion)
        {
            _OpinionRepository.Delete(opinion);
        }

        public List<Opinion> GetAllOpinions()
        {
            return _OpinionRepository.GetAllOpinions();
        }

        public Opinion GetOpinionById(int id)
        {
            return _OpinionRepository.GetOpinionById(id);
        }
    }
}
