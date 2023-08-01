using DreamWedds.Manager.Application.Template;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IApiService _apiService;

    public IndexModel(ILogger<IndexModel> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }

    public async Task OnGetAsyc()
    {
        _logger.LogInformation("On Get Async");
        var request = new SearchTemplateRequest() { PageNumber = 1, PageSize = 20 };
        var templates = await _apiService.GetWeddingTemplatesAsync(request);
        _logger.LogInformation("Response: ", templates);
        ViewData["Templates"] = templates.Data;
    }
}
