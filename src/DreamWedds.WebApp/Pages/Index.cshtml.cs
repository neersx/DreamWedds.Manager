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

    public async Task OnGet()
    {
        var request = new SearchTemplateRequest() { PageNumber = 1, PageSize = 4 };
        var templates = await _apiService.GetWeddingTemplatesAsync(request);
        ViewData["Templates"] = templates.Data.Where(x => x.Type == 2).ToList();
    }

    public async Task<PartialViewResult> OnGetTemplateData()
    {
        var request = new SearchTemplateRequest() { PageNumber = 1, PageSize = 4 };
        var templates = await _apiService.GetWeddingTemplatesAsync(request);
        var data = templates.Data.Where(x => x.Type == 2).ToList();
        _logger.LogInformation("Data received");
        return Partial("_QuickThemes", data);
    }
}
