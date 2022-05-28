using TopEntertainment.Domain.Commands;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.AccessData.Commands
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly TopEntertainmentDbContext _context;
        public OpinionRepository(TopEntertainmentDbContext context)
        {
            _context = context;
        }
        public void Add(Opinion opinion)
        {
            _context.Opinions.Add(opinion);
            _context.SaveChanges();
        }

        public void Delete(Opinion opinion)
        {
            _context.Opinions.Remove(opinion);
            _context.SaveChanges();
        }

        public List<Opinion> GetAllOpinions()
        {
            return _context.Opinions.ToList();
        }

        public Opinion GetOpinionById(int id)
        {
            return _context.Opinions.FirstOrDefault(Opinion => Opinion.OpinionId == id);
        }

        public List<int> GetOpinionsByJuegoId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Opinion opinion)
        {
            _context.Update(opinion);
            _context.SaveChanges();
        }
    }
}

