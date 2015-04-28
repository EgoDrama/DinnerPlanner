using System;
using Common.Domain.Model;

namespace Common.Repository
{
    public interface IRepository<TEntity> 
        where TEntity : class 
    {
        TEntity Get(Guid aggregateRootId);
        void Save(IAggregate aggregate, int version);
    }
}