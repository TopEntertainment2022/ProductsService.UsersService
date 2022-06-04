using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Domain.Commands
{
    public interface IValuationRepository
    {
        List<Valuation> GetAllValuations();
        List<Valuation> GetValuationsByUserId(int id);
        Valuation GetValuationById(int id);
        void Add(Valuation valoration);
        void Update(Valuation valoration);
        void Delete(Valuation valoration);
    }
}
