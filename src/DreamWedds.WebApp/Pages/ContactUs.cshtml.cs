using DreamWedds.Manager.Application.Contact;
using DreamWedds.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages;

public class ContactUsModel : PageModel
{
    [BindProperty]
    public new ContactUsRequest Request { get; set; } = default!;

    private readonly ILogger<ContactUsModel> _logger;
    private readonly IApiService _apiService;

    public ContactUsModel(ILogger<ContactUsModel> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }
    public async Task OnGet()
    {
        //var MetaTags = await _mediator.Send(new GetAllMetaTagsByPageNameQuery(KnownValues.KnownHtmlPage.ContactUs));
        //string MetagTagsString = HtmlPageExtensions.GetMetadataString(MetaTags.Data);
        //ViewData["LoadMetaTag"] = MetagTagsString;
    }

    public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _apiService.SubmitContactUsRequest(Request);
        ViewData["Success"] = "Success";
        return Page();
    }
}
