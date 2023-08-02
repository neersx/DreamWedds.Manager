using DreamWedds.Manager.Application.Template;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages.Themes.Weddings;

public class DetailsModel : PageModel
{
    [Obsolete]
    private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
    private readonly IApiService _apiService;

    [Obsolete]
    public DetailsModel(IApiService apiService, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
    {
        _environment = environment;
        _apiService = apiService;
    }

    public TemplateDto Detail { get; set; }
    public List<string> Screenshots { get; set; }
    public string ScreenshotFolder { get; set; }

    [Obsolete]
    public async Task OnGetAsync(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("In correct url");
        name = name.Replace('-', ' ').ToUpper();
        Detail = await _apiService.GetTemplateByNameAsync(name);
        string? templateFolderPath = Detail.TemplateFolderPath;
        Screenshots = GetTempalteScreenShots(templateFolderPath);
    }

    [Obsolete]
    private List<string> GetTempalteScreenShots(string? folderName)
    {
        if (string.IsNullOrEmpty(folderName))
            return new List<string>();

        ScreenshotFolder = $"assets/templates/wedding/{folderName}/images/screenshots";
        string folderPath = Path.Combine(_environment.WebRootPath, ScreenshotFolder);
        if (Directory.Exists(folderPath))
        {
            string[] allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            return Directory.GetFiles(folderPath)
                .Where(file => allowedExtensions.Contains(Path.GetExtension(file), StringComparer.OrdinalIgnoreCase))
                .Select(file => Path.GetFileName(file))
                .ToList();
        }
        return new List<string>();
    }
}
