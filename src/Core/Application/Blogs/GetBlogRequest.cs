namespace DreamWedds.Manager.Application.Blogs;

public class GetBlogRequest : IRequest<BlogDto>
{
    public Guid Id { get; set; }

    public GetBlogRequest(Guid id) => Id = id;
}

public class GetBlogRequestHandler : IRequestHandler<GetBlogRequest, BlogDto>
{
    private readonly IRepository<Domain.Entities.DreamWedds.Blog> _repository;
    private readonly IStringLocalizer _t;

    public GetBlogRequestHandler(IRepository<Domain.Entities.DreamWedds.Blog> repository, IStringLocalizer<GetBlogRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<BlogDto> Handle(GetBlogRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<Domain.Entities.DreamWedds.Blog, BlogDto>)new BlogByIdWithCommentsSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["Blog {0} Not Found.", request.Id]);
}

public class BlogByIdWithCommentsSpec : Specification<Domain.Entities.DreamWedds.Blog, BlogDto>, ISingleResultSpecification
{
    public BlogByIdWithCommentsSpec(Guid id) =>
        Query
            .Where(p => p.Id == id)
            .Include(p => p.Comments);
}
