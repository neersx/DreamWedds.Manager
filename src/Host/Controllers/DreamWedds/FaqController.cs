using DreamWedds.Manager.Application.FaqModel;

namespace DreamWedds.Manager.Host.Controllers.DreamWedds;

public class FaqController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Search faqs using available filters.", "")]
    public Task<PaginationResponse<FaqDto>> SearchAsync(SearchFaqRequest request)
    {
        return Mediator.Send(request);
    }
}
