using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WWWRedirect.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        string url = "https://adamstirtan.notion.site/adamstirtan/Adam-Stirtan-s-Blog-e3066ed9611f44c2887403ff3680af7d";

        return Redirect(url);
    }
}

