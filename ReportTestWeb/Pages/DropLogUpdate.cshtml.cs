using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportsTestLibary.Data;
using ReportsTestLibary.Models;
using System.ComponentModel.DataAnnotations;


namespace ReportTestWeb.Pages
{
    public class DropLogUpdateModel : PageModel
    {
        private readonly IDatabaseData _db;

        // [DataType(DataType.Date)]
        // [BindProperty(SupportsGet = true)]
        //  public DateTime StartDate { get; set; } = DateTime.Now;

        // [DataType(DataType.Date)]
        // [BindProperty(SupportsGet = true)]
        // public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        // [BindProperty(SupportsGet = true)]
        // public bool SearchEnabled { get; set; } = false;
 
        [BindProperty(SupportsGet = true)]
        public int RecNo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DeliveryType { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime DeliveredWhen { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DeliveredBy { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BusinessName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DeliveredTo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ItemType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CheckNo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string RecievedBy { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ProcessedBy { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime ProcessedDate { get; set; }


        // WTF THIS LINE BELOW MIGHT NEED MODIFICATION IN IT'S SECOND PART "DropOffRecords" --> DropOffRecord //
        public List<DropOffModel> DropOffRecord { get; set; }
        


        public DropLogUpdateModel(IDatabaseData db)
        {
            _db = db;
        }

        public void OnGet()
        {
            DropOffRecord = _db.GetDropOffRecordSingle(RecNo);
        }

        public IActionResult OnPost()
        {
            _db.UpdateRecord(RecNo, DeliveryType, DeliveredWhen, DeliveredBy, BusinessName, DeliveredTo, ItemType, CheckNo, RecievedBy, ProcessedBy, ProcessedDate);
            return RedirectToPage("/Index");

        }
    }
}
