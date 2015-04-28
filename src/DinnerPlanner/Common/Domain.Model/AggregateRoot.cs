using System;

namespace Common.Domain.Model
{
    public abstract class AggregateRoot : IAggregate
    {
        public Guid AggregateRootId { get; set; }
        public int Version { get; set; }
    }
}