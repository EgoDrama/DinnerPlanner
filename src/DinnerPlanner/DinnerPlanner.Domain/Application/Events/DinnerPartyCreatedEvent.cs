using System;
using Common.Events;

namespace DinnerPlanner.Domain.Application.Events
{
    public class DinnerPartyCreatedEvent : IEvent
    {
        public Guid AggregateId { get; set; }
    }
}