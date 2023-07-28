
using DreamWedds.Manager.Application.Template;
using DreamWedds.Manager.Application.Wedding;

namespace DreamWedds.Manager.Host.Controllers.Wedding;

public class WeddingController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Search wedding using available filters.", "")]
    public Task<PaginationResponse<WeddingDto>> SearchAsync(SearchWeddingRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [MustHavePermission(FSHAction.View, FSHResource.Wedding)]
    [OpenApiOperation("Get wedding details.", "")]
    public Task<WeddingDto> GetAsync(Guid id)
    {
        return Mediator.Send(new GetWeddingRequest(id));
    }
}
