using DreamWedds.Manager.Shared.Events;

namespace DreamWedds.Manager.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}