using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Template;

public class GetTemplateByNameRequest : IRequest<TemplateDto>
{
    public string Name { get; set; }
    public GetTemplateByNameRequest(string name) => Name = name;
}

public class GetTemplateByNameRequestHandler : IRequestHandler<GetTemplateByNameRequest, TemplateDto>
{
    private readonly IRepository<TemplateMaster> _repository;
    private readonly IStringLocalizer _t;

    public GetTemplateByNameRequestHandler(IRepository<TemplateMaster> repository, IStringLocalizer<GetTemplateByNameRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<TemplateDto> Handle(GetTemplateByNameRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<TemplateMaster, TemplateDto>)new TemplateByNameSpec(request.Name), cancellationToken)
        ?? throw new NotFoundException(_t["Template {0} Not Found.", request.Name]);
}
