using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportsTestLibary.Models;
using System.ComponentModel.DataAnnotations;

namespace ReportTestWeb.Pages
{
    public class DropLogSearchModel : PageModel
    {
        [DataType(DataType.Date)]
        [BindProperty (SupportsGet = true)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);


        public List<DropOffModel> DropOffRecords { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            
            return Page();

        }
    }
}
