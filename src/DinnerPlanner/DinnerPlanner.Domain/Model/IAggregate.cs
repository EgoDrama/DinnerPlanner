using System;

namespace DinnerPlanner.Domain.Model
{
    public interface IAggregate
    {
        Guid AggregateRootId { get; set; }
    }
}