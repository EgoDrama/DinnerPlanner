using System;

namespace DinnerPlanner.Domain.Domain.Model
{
    public interface IAggregate
    {
        Guid AggregateRootId { get; set; }
    }
}