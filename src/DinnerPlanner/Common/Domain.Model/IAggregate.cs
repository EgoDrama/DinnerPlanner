using System;

namespace Common.Domain.Model
{
    public interface IAggregate
    {
        Guid AggregateRootId { get; set; }
    }
}