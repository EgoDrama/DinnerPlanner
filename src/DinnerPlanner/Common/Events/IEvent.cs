using System;

namespace Common.Events
{
    public interface IEvent
    {
        Guid AggregateId { get; set; }
    }
}