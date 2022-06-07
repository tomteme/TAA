using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
namespace Projekti.Pages
{
    [Authorize(Policy = "Kirjautunut")]
    public class WeatherModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
