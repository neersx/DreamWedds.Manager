using DreamWedds.Manager.Domain.Entities.DreamWedds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWedds.Manager.Application.Blogs;

public class GetBlogByNameRequest : IRequest<BlogDto>
{
    public string Name { get; set; }

    public GetBlogByNameRequest(string name) => Name = name;
}
public class GetBlogByNameRequestHandler : IRequestHandler<GetBlogByNameRequest, BlogDto>
{
    private readonly IRepository<Blog> _repository;
    private readonly IStringLocalizer _t;

    public GetBlogByNameRequestHandler(IRepository<Blog> repository, IStringLocalizer<GetBlogByNameRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<BlogDto> Handle(GetBlogByNameRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<Blog, BlogDto>)new BlogByNameSpec(request.Name), cancellationToken)
        ?? throw new NotFoundException(_t["Blog {0} Not Found.", request.Name]);
}

