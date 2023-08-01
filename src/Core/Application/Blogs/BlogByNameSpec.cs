using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Application.Blogs;

public class BlogByNameSpec : Specification<Blog, BlogDto>, ISingleResultSpecification
{
    public BlogByNameSpec(string name) =>
        Query.Where(p => p.BlogName == name);
}


public class BlogByUrlNameSpec : Specification<Blog, BlogDto>, ISingleResultSpecification
{
    public BlogByUrlNameSpec(string name) =>
        Query.Where(p => p.BlogName == name);
}
