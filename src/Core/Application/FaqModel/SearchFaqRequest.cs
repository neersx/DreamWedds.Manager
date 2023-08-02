using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.FaqModel;

public class SearchFaqRequest : PaginationFilter, IRequest<PaginationResponse<FaqDto>>
{
    public int? FaqType { get; set; }
}

public class SearchFaqRequestHandler : IRequestHandler<SearchFaqRequest, PaginationResponse<FaqDto>>
{
    private readonly IReadRepository<Faq> _repository;

    public SearchFaqRequestHandler(IReadRepository<Faq> repository) => _repository = repository;

    public async Task<PaginationResponse<FaqDto>> Handle(SearchFaqRequest request, CancellationToken cancellationToken)
    {
        var spec = new FaqsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken: cancellationToken);
    }
}

public class FaqsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Faq, FaqDto>
{
    public FaqsBySearchRequestSpec(SearchFaqRequest request)
        : base(request) =>
        Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}