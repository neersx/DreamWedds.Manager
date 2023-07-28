using DreamWedds.Manager.Application.Catalog.Products;
using DreamWedds.Manager.Domain.Entities.DreamWedds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWedds.Manager.Application.Blogs;

public class UpdateBlogRequestValidator : CustomValidator<UpdateProductRequest>
{
    public UpdateBlogRequestValidator(IReadRepository<Blog> productRepo, IStringLocalizer<UpdateProductRequestValidator> T)
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .MaximumLength(5)
            .MustAsync(async (product, name, ct) =>
                    await productRepo.FirstOrDefaultAsync(new BlogByNameSpec(name), ct)
                        is not Blog existingProduct || existingProduct.Id == product.Id)
                .WithMessage((_, name) => T["Blog {0} already Exists.", name]);

        RuleFor(p => p.Rate)
            .GreaterThanOrEqualTo(1);

        RuleFor(p => p.Image);
    }
}
