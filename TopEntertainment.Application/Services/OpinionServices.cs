using AutoMapper;
using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Application.Services
{
    public interface IOpinionService
    {
        List<Opinion> GetAllOpinions();//
        List<int> GetOpinionsByJuegoId(int id);
        Opinion GetOpinionById(int id);//
        void AddOpinion(Opinion opinion);//
        void Update(Opinion opinion);
        void Delete(Opinion opinion);
    }
    public class OpinionServices : IOpinionService
    {
        private readonly IOpinionRepository _OpinionRepository;
        private readonly IMapper _mapper;
        public OpinionServices(IOpinionRepository iOpinionRepository, IMapper mapper)
        {
            _OpinionRepository = iOpinionRepository;
            _mapper = mapper;
        }

        public void AddOpinion(Opinion opinion)
        {
            //var opinionMapper = _mapper.Map<Opinion>(opinion);
            _OpinionRepository.Add(opinion);
            //return opinionMapper;
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

        public List<int> GetOpinionsByJuegoId(int id)
        {
            return _OpinionRepository.GetOpinionsByJuegoId(id);
        }

        public void Update(Opinion opinion)
        {
            _OpinionRepository.Update(opinion);
        }
    }
}
