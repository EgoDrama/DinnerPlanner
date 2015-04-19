using System;
using DinnerPlanner.Domain.Model;

namespace DinnerPlanner.Domain.Repository
{
    public class UserRepository : IRepository<User>
    {
        public User Get(Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public void Save(IAggregate aggregate, int version)
        {
            throw new NotImplementedException();
        }
    }
}