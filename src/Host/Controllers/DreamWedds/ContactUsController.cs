using DreamWedds.Manager.Application.Contact;

namespace DreamWedds.Manager.Host.Controllers.DreamWedds;
public class ContactUsController : VersionedApiController
{
    [HttpPost("")]
    [AllowAnonymous]
    [OpenApiOperation("Create a new contactus reqest", "")]
    public Task<Guid> SubmitContactUsRequest(ContactUsRequest request)
    {
        return Mediator.Send(request);
    }
}
