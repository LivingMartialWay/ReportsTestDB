using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportsTestLibary.Data;
using ReportsTestLibary.Models;
using System.ComponentModel.DataAnnotations;


namespace ReportTestWeb.Pages
{
    public class DropLogSearchModel : PageModel
    {
        private readonly IDatabaseData _db;

        [DataType(DataType.Date)]
        [BindProperty (SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [BindProperty(SupportsGet =true)]
        public bool SearchEnabled { get; set; } = false;

        public List<DropOffModel> DropOffRecords { get; set; }

        public DropLogSearchModel(IDatabaseData db)
        {
            _db = db;
        }

        public void OnGet()
        {
            if (SearchEnabled == true)
            {
                DropOffRecords = _db.GetDropOffRecordList(StartDate, EndDate);
            }
        }

        public IActionResult OnPost()
        {
            
            return RedirectToPage(new { SearchEnabled = true, StartDate, EndDate});

        }
    }
}
