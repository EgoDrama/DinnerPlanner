using Common.Events;

namespace Common.Domain.Model
{
    public class DomainEventPublisher
    {
        public void Publish<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : IEvent
        {
            
        }
    }
}