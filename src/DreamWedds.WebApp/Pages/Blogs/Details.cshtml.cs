using DreamWedds.Manager.Application.Blogs;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages.Blogs;

public class DetailsModel : PageModel
{
    private readonly ILogger<DetailsModel> _logger;
    private readonly IApiService _apiService;

    public DetailsModel(ILogger<DetailsModel> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }

    public BlogDto Detail { get; set; }
    public async Task OnGetAsync(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Incorrect Blog Name");

        Detail = await _apiService.GetBlogByNameAsync(name);

        //var quickTags = new QuickMetaTags(Detail.Title, Detail.ImageUrl, Detail.SpecialNote, Request.GetDisplayUrl(), "Content");
        //ViewData["LoadMetaTag"] = HtmlPageExtensions.GetMetadataString(quickTags);
        var request = new SearchBlogRequest() { PageNumber = 1, PageSize = 20 };
        var result = await _apiService.GetBlogsAsync(request);
        ViewData["Blogs"] = result.Data.ToList();
    }
}
