using DreamWedds.Manager.Domain.Common.Events;
using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Blogs;
public class UpdateBlogRequest : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Quote { get; set; }
    public string? AuthorName { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public int BlogType { get; set; } = 0;
    public string? SpecialNote { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool DeleteCurrentImage { get; set; } = false;
    public FileUploadRequest? Image { get; set; }
}

public class UpdateBlogRequestHandler : IRequestHandler<UpdateBlogRequest, Guid>
{
    private readonly IRepository<Blog> _repository;
    private readonly IStringLocalizer _t;
    private readonly IFileStorageService _file;

    public UpdateBlogRequestHandler(IRepository<Blog> repository, IStringLocalizer<UpdateBlogRequestHandler> localizer, IFileStorageService file) =>
        (_repository, _t, _file) = (repository, localizer, file);

    public async Task<Guid> Handle(UpdateBlogRequest request, CancellationToken cancellationToken)
    {
        var Blog = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (Blog == null)
        {
            string blogImagePath = await _file.UploadAsync<Blog>(request.Image, FileType.Image, cancellationToken);

            var blog = new Blog(request.Title, request.Content, request.BlogType, blogImagePath);

            // Add Domain Events to be raised after the commit
            blog.DomainEvents.Add(EntityCreatedEvent.WithEntity(blog));

            await _repository.AddAsync(blog, cancellationToken);

            return blog.Id;
        }

        // Remove old image if flag is set
        if (request.DeleteCurrentImage)
        {
            string? currentBlogImagePath = Blog.ImageUrl;
            if (!string.IsNullOrEmpty(currentBlogImagePath))
            {
                string root = Directory.GetCurrentDirectory();
                _file.Remove(Path.Combine(root, currentBlogImagePath));
            }

            Blog = Blog.ClearImagePath();
        }

        string? BlogImagePath = request.Image is not null
            ? await _file.UploadAsync<Blog>(request.Image, FileType.Image, cancellationToken)
            : null;

        var updatedBlog = Blog.Update(request.Title, request.Content, request.BlogType, BlogImagePath);

        // Add Domain Events to be raised after the commit
        Blog.DomainEvents.Add(EntityUpdatedEvent.WithEntity(Blog));

        await _repository.UpdateAsync(updatedBlog, cancellationToken);

        return request.Id;
    }
}
