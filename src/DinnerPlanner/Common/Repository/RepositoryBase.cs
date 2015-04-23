using System;

namespace Common.Repository
{
    public class RepositoryBase<TEntity, TAggregate> : IRepository<TEntity, TAggregate> 
        where TEntity: class
        where TAggregate : class
    {
        public TEntity Get(Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public void Save(TAggregate aggregate, int version)
        {
            throw new NotImplementedException();
        }
    }
}