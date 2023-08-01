
using DreamWedds.Manager.Application.Blogs;
using DreamWedds.Manager.Application.Template;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        public List<BlogDto> Blogs { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly IApiService _apiService;

        public IndexModel(ILogger<IndexModel> logger, IApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        public async Task OnGetAsync()
        {
            var request = new SearchBlogRequest() { PageNumber = 1, PageSize = 20 };
            var result = await _apiService.GetBlogsAsync(request);

            if (result == null)
                throw new Exception("No Blogs available to display.");
            Blogs = result.Data.ToList();

            //var MetaTags = await _mediator.Send(
            //    new GetAllMetaTagsByPageNameQuery(KnownValues.KnownHtmlPage.Blog)
            //);
            //string MetagTagsString = HtmlPageExtensions.GetMetadataString(MetaTags.Data);
            ViewData["LoadMetaTag"] = "";
        }
    }
}
