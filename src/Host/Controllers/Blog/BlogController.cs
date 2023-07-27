using DreamWedds.Manager.Application.Blog;
using DreamWedds.Manager.Application.Catalog.Products;

namespace DreamWedds.Manager.Host.Controllers.Blog;

public class BlogController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Products)]
    [OpenApiOperation("Search blogs using available filters.", "")]
    public Task<PaginationResponse<BlogDto>> SearchAsync(SearchBlogRequest request)
    {
        return Mediator.Send(request);
    }
}
