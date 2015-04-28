using System;

namespace Common.Events
{
    public class Event : IEvent
    {
        public int Version { get; set; }
        public Guid AggregateId { get; set; }
    }
}