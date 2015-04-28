using System;
using Common.Domain.Model;

namespace Common.Repository
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> 
        where TEntity: class
    {
        public TEntity Get(Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public void Save(IAggregate aggregate, int version)
        {
            throw new NotImplementedException();
        }
    }
}