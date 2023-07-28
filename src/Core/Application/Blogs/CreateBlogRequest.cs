using DreamWedds.Manager.Domain.Common.Events;
using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Blogs;
public class CreateBlogRequest : IRequest<Guid>
{
    public string Title { get; set; }
    public string? BlogSubject { get; set; }
    public string? Quote { get; set; }
    public string? AuthorName { get; set; }
    public string Content { get; set; }
    public int BlogType { get; set; } = 0;
    public string? SpecialNote { get; set; }
    public FileUploadRequest? Image { get; set; }
}

public class CreateBlogRequestHandler : IRequestHandler<CreateBlogRequest, Guid>
{
    private readonly IRepository<Blog> _repository;
    private readonly IFileStorageService _file;

    public CreateBlogRequestHandler(IRepository<Blog> repository, IFileStorageService file) =>
        (_repository, _file) = (repository, file);

    public async Task<Guid> Handle(CreateBlogRequest request, CancellationToken cancellationToken)
    {
        string BlogImagePath = await _file.UploadAsync<Blog>(request.Image, FileType.Image, cancellationToken);

        var Blog = new Blog(request.Title, request.Content, request.BlogType, BlogImagePath) { BlogSubject = request.BlogSubject, SpecialNote = request.SpecialNote, Quote = request.Quote, AuthorName = request?.AuthorName };

        // Add Domain Events to be raised after the commit
        Blog.DomainEvents.Add(EntityCreatedEvent.WithEntity(Blog));

        await _repository.AddAsync(Blog, cancellationToken);

        return Blog.Id;
    }
}
