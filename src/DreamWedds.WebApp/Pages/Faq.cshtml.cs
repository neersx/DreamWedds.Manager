using DreamWedds.Manager.Application.FaqModel;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages;

public class FaqModel : PageModel
{
    public List<FaqDto>? FaqList { get; set; }

    private readonly ILogger<FaqModel> _logger;
    private readonly IApiService _apiService;

    public FaqModel(ILogger<FaqModel> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }
    public async Task OnGet()
    {
        var request = new SearchFaqRequest() { PageNumber = 1, PageSize = 20 };
        var faqs = await _apiService.GetFaqsAsync(request);
        FaqList = faqs.Data;

        //var MetaTags = await _mediator.Send(new GetAllMetaTagsByPageNameQuery(KnownValues.KnownHtmlPage.Faq));
        //string MetagTagsString = HtmlPageExtensions.GetMetadataString(MetaTags.Data) ;
        //ViewData["LoadMetaTag"] = MetagTagsString;
    }
}
