using DreamWedds.Manager.Application.Wedding;
using DreamWedds.Manager.Application.Wedding;
using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Wedding;

public class SearchWeddingRequest : PaginationFilter, IRequest<PaginationResponse<WeddingDto>>
{
    public string? Tags { get; set; }
}

public class SearchWeddingRequestHandler : IRequestHandler<SearchWeddingRequest, PaginationResponse<WeddingDto>>
{
    private readonly IReadRepository<WeddingMaster> _repository;

    public SearchWeddingRequestHandler(IReadRepository<WeddingMaster> repository) => _repository = repository;

    public async Task<PaginationResponse<WeddingDto>> Handle(SearchWeddingRequest request, CancellationToken cancellationToken)
    {
        var spec = new WeddingsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken: cancellationToken);
    }
}

public class WeddingsBySearchRequestSpec : EntitiesByPaginationFilterSpec<WeddingMaster, WeddingDto>
{
    public WeddingsBySearchRequestSpec(SearchWeddingRequest request)
        : base(request) =>
        Query
            .Include(x => x.BrideAndMaids)
            .OrderBy(c => c.CreatedOn, !request.HasOrderBy())
            .Where(p => !p.IsDeleted);
}