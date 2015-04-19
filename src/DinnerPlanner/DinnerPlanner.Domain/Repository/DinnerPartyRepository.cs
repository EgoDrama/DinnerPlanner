using System;
using System.Runtime.InteropServices.WindowsRuntime;
using DinnerPlanner.Domain.Model;

namespace DinnerPlanner.Domain.Repository
{
    public class DinnerPartyRepository : IRepository<DinnerParty>
    {
        public DinnerParty Get(Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public void Save(IAggregate aggregate, int version)
        {
            throw new NotImplementedException();
        }
    }
}