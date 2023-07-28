using DreamWedds.Manager.Application.Blogs;

namespace DreamWedds.Manager.Host.Controllers.Blog;

public class BlogsController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Search blogs using available filters.", "")]
    public Task<PaginationResponse<BlogDto>> SearchAsync(SearchBlogRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [MustHavePermission(FSHAction.View, FSHResource.Blogs)]
    [OpenApiOperation("Get blog details.", "")]
    public Task<BlogDto> GetAsync(Guid id)
    {
        return Mediator.Send(new GetBlogRequest(id));
    }

    [HttpGet("{name}")]
    [AllowAnonymous]
    [OpenApiOperation("Get blog details.", "")]
    public Task<BlogDto> GetBlogByNameAsync(string name)
    {
        return Mediator.Send(new GetBlogByNameRequest(name));
    }

    [HttpPost]
    [MustHavePermission(FSHAction.Create, FSHResource.Blogs)]
    [OpenApiOperation("Create a new blog.", "")]
    public Task<Guid> CreateAsync(CreateBlogRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(FSHAction.Update, FSHResource.Blogs)]
    [OpenApiOperation("Update a blog.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateBlogRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
