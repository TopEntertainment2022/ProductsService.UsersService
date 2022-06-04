using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Application.Services
{
    public interface IValuationService
    {
        List<Valuation> GetAllValuations();
        List<Valuation> GetValuationsByUserId(int id);
        Valuation GetValuationsById(int id);
        void Add(Valuation valuation);
        void Update(Valuation valuation);
        void Delete(Valuation valuation);
    }
    public class ValuationService : IValuationService
    {
        private readonly IValuationRepository _valuationRepository;

        public ValuationService(IValuationRepository valuationRepository)
        {
            _valuationRepository = valuationRepository;
        }

        public void Add(Valuation valuation)
        {
            _valuationRepository.Add(valuation);
        }

        public void Delete(Valuation valuation)
        {
            _valuationRepository.Delete(valuation);
        }

        public List<Valuation> GetAllValuations()
        {
            return _valuationRepository.GetAllValuations();
        }

        public Valuation GetValuationsById(int id)
        {
            return _valuationRepository.GetValuationById(id);
        }

        public List<Valuation> GetValuationsByUserId(int id)
        {
            return _valuationRepository.GetValuationsByUserId(id);
        }

        public void Update(Valuation valuation)
        {
            _valuationRepository.Update(valuation);
        }
    }
}
