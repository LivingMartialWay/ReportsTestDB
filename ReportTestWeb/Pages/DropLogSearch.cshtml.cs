using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReportTestWeb.Pages
{
    public class DropLogSearchModel : PageModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return Page();

        }
    }
}
