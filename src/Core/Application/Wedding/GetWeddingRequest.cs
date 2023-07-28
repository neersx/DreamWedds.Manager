using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Wedding;
public class GetWeddingRequest : IRequest<WeddingDto>
{
    public Guid Id { get; set; }

    public GetWeddingRequest(Guid id) => Id = id;
}

public class GetWeddingRequestHandler : IRequestHandler<GetWeddingRequest, WeddingDto>
{
    private readonly IRepository<WeddingMaster> _repository;
    private readonly IStringLocalizer _t;

    public GetWeddingRequestHandler(IRepository<WeddingMaster> repository, IStringLocalizer<GetWeddingRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<WeddingDto> Handle(GetWeddingRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<WeddingMaster, WeddingDto>)new WeddingByIdWithCommentsSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["Wedding {0} Not Found.", request.Id]);
}

public class WeddingByIdWithCommentsSpec : Specification<WeddingMaster, WeddingDto>, ISingleResultSpecification
{
    public WeddingByIdWithCommentsSpec(Guid id) =>
        Query
            .Where(p => p.Id == id)
            .Include(p => p.BrideAndMaids)
            .Include(x => x.GroomAndMen)
            .Include(x => x.WeddingEvents)
            .Include(x => x.TimeLines);
}
