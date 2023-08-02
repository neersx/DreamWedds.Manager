using DreamWedds.Manager.Domain.Common.Events;
using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Contact;

public class CreateContactUsRequestHandler : IRequestHandler<ContactUsRequest, Guid>
{
    private readonly IRepository<ContactUs> _repository;

    public CreateContactUsRequestHandler(IRepository<ContactUs> repository) =>
        _repository = repository;

    public async Task<Guid> Handle(ContactUsRequest request, CancellationToken cancellationToken)
    {
        var contactUs = new ContactUs(request.FirstName, request.LastName, request.Message, request.Mobile, request.Email);
        contactUs.DomainEvents.Add(EntityCreatedEvent.WithEntity(contactUs));

        await _repository.AddAsync(contactUs, cancellationToken);

        return contactUs.Id;
    }
}
