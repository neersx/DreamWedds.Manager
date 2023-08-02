using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Template;

public class TemplateByNameSpec : Specification<TemplateMaster, TemplateDto>, ISingleResultSpecification
{
    public TemplateByNameSpec(string name) =>
        Query.Where(p => p.Name == name);
}
