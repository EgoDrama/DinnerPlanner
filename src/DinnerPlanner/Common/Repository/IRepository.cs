using System;

namespace Common.Repository
{
    public interface IRepository<TEntity, TAggregate> 
        where TEntity : class 
        where TAggregate : class
    {
        TEntity Get(Guid aggregateRootId);
        void Save(TAggregate aggregate, int version);
    }
}