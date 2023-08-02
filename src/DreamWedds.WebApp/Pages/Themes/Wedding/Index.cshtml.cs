using DreamWedds.Manager.Application.Common.Models;
using DreamWedds.Manager.Application.Template;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages.Themes.Weddings;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IApiService _apiService;
    public List<TemplateDto> Templates { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        _logger.LogInformation("On Get Async");
        var request = new SearchTemplateRequest() { PageNumber = 1, PageSize = 20 };
        var templates = await _apiService.GetWeddingTemplatesAsync(request);
        _logger.LogInformation("Response: ", templates);
        Templates = templates.Data.Where(x => x.Type == 2).ToList();
    }
}
