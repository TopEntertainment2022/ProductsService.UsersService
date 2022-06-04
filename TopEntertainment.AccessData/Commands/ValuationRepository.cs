using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.AccessData.Commands
{
    public class ValuationRepository : IValuationRepository
    {
        private readonly TopEntertainmentDbContext _context;

        public ValuationRepository(TopEntertainmentDbContext context)
        {
            _context = context;
        }

        public void Add(Valuation valuation)
        {
            _context.Valuations.Add(valuation);
            _context.SaveChanges();
        }

        public void Delete(Valuation valuation)
        {
            _context.Valuations.Remove(valuation);
            _context.SaveChanges();
        }

        public List<Valuation> GetAllValuations()
        {
            return _context.Valuations.ToList();
        }

        public Valuation GetValuationById(int id)
        {
            return _context.Valuations.FirstOrDefault(Valuation => Valuation.Id == id);
        }

        public List<Valuation> GetValuationsByUserId(int id)
        {
            return _context.Valuations.Where(Valuation => Valuation.UsuarioId == id).ToList();
        }

        public void Update(Valuation valuation)
        {
            _context.Update(valuation);
            _context.SaveChanges();
        }
    }
}
