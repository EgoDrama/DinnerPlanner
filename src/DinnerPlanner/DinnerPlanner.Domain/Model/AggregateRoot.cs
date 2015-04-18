using System;

namespace DinnerPlanner.Domain.Model
{
    public abstract class AggregateRoot : IAggregate
    {
        public Guid AggregateRootId { get; set; } 
    }
}