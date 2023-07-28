namespace DreamWedds.Manager.Application.Blogs;

public class BlogByNameSpec : Specification<Domain.Entities.DreamWedds.Blog>, ISingleResultSpecification
{
    public BlogByNameSpec(string name) =>
        Query.Where(p => p.BlogName == name);
}


public class BlogByUrlNameSpec : Specification<Domain.Entities.DreamWedds.Blog>, ISingleResultSpecification
{
    public BlogByUrlNameSpec(string name) =>
        Query.Where(p => p.BlogName == name);
}
