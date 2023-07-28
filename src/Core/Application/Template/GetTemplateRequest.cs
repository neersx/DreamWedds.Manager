using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Template;
public class GetTemplateRequest : IRequest<TemplateDto>
{
    public int Id { get; set; }

    public GetTemplateRequest(int id) => Id = id;
}

public class GetTemplateRequestHandler : IRequestHandler<GetTemplateRequest, TemplateDto>
{
    private readonly IRepository<TemplateMaster> _repository;
    private readonly IStringLocalizer _t;

    public GetTemplateRequestHandler(IRepository<TemplateMaster> repository, IStringLocalizer<GetTemplateRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<TemplateDto> Handle(GetTemplateRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<TemplateMaster, TemplateDto>)new TemplateByIdWithCommentsSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["Template {0} Not Found.", request.Id]);
}

public class TemplateByIdWithCommentsSpec : Specification<TemplateMaster, TemplateDto>, ISingleResultSpecification
{
    public TemplateByIdWithCommentsSpec(int id) =>
        Query
            .Where(p => p.Id == id)
            .Include(p => p.Comments)
            .Include(x => x.WeddingTemplateSettings);
}
