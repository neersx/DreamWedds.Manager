using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Blogs;

public class UpdateBlogRequestValidator : CustomValidator<UpdateBlogRequest>
{
    public UpdateBlogRequestValidator(IReadRepository<Blog> productRepo, IStringLocalizer<UpdateBlogRequestValidator> T)
    {
        RuleFor(p => p.Title)
            .NotEmpty()
            .MaximumLength(5)
            .MustAsync(async (product, name, ct) =>
                    await productRepo.FirstOrDefaultAsync(new BlogByNameSpec(name), ct)
                        is not BlogDto existingProduct || existingProduct.Id == product.Id)
                .WithMessage((_, name) => T["Blog {0} already Exists.", name]);

        RuleFor(p => p.Image);
    }
}
