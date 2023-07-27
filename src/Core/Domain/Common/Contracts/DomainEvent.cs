using DreamWedds.Manager.Shared.Events;

namespace DreamWedds.Manager.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}