using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DreamWedds.WebApp.Pages;

public class AboutUsModel : PageModel
{
    public async Task OnGet()
    {
        //var MetaTags = await _mediator.Send(new GetAllMetaTagsByPageNameQuery(KnownValues.KnownHtmlPage.AboutUs));
        //string MetagTagsString = HtmlPageExtensions.GetMetadataString(MetaTags.Data) ;
        //ViewData["LoadMetaTag"] = MetagTagsString;
    }
}
