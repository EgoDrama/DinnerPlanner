using System;
using DinnerPlanner.Domain.Model;

namespace DinnerPlanner.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid aggregateRootId);
        void Save(IAggregate aggregate, int version);
    }
}