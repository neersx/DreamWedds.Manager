using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Template;

public class SearchTemplateRequest : PaginationFilter, IRequest<PaginationResponse<TemplateDto>>
{
    public string? Tags { get; set; }
}

public class SearchTemplateRequestHandler : IRequestHandler<SearchTemplateRequest, PaginationResponse<TemplateDto>>
{
    private readonly IReadRepository<TemplateMaster> _repository;

    public SearchTemplateRequestHandler(IReadRepository<TemplateMaster> repository) => _repository = repository;

    public async Task<PaginationResponse<TemplateDto>> Handle(SearchTemplateRequest request, CancellationToken cancellationToken)
    {
        var spec = new TemplatesBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken: cancellationToken);
    }
}

public class TemplatesBySearchRequestSpec : EntitiesByPaginationFilterSpec<TemplateMaster, TemplateDto>
{
    public TemplatesBySearchRequestSpec(SearchTemplateRequest request)
        : base(request) =>
        Query
            .Include(x => x.Comments)
            .OrderBy(c => c.CreatedOn, !request.HasOrderBy())
            .Where(p => p.Tags.Contains(request.Tags), !string.IsNullOrEmpty(request.Tags));
}