namespace DreamWedds.Manager.Application.Blogs;

public class SearchBlogRequest : PaginationFilter, IRequest<PaginationResponse<BlogDto>>
{
    public int? BlogType { get; set; }
}

public class SearchBlogRequestHandler : IRequestHandler<SearchBlogRequest, PaginationResponse<BlogDto>>
{
    private readonly IReadRepository<Domain.Entities.DreamWedds.Blog> _repository;

    public SearchBlogRequestHandler(IReadRepository<Domain.Entities.DreamWedds.Blog> repository) => _repository = repository;

    public async Task<PaginationResponse<BlogDto>> Handle(SearchBlogRequest request, CancellationToken cancellationToken)
    {
        var spec = new BlogsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken: cancellationToken);
    }
}

public class BlogsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Domain.Entities.DreamWedds.Blog, BlogDto>
{
    public BlogsBySearchRequestSpec(SearchBlogRequest request)
        : base(request) =>
        Query
            .Include(x => x.Comments)
            .OrderBy(c => c.CreatedOn, !request.HasOrderBy())
            .Where(p => p.BlogType >= request.BlogType, request.BlogType.HasValue);
}
