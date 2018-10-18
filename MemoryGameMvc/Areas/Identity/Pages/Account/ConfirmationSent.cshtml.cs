using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MemoryGameMvc.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmationSentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}