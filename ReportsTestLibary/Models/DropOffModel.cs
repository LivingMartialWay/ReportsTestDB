using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsTestLibary.Models
{
    public class DropOffModel
    {
        public int RecNo { get; set; }
        public string DeliveryType { get; set; }
        public DateTime DeliveredWhen { get; set; }
        public string DeliveredBy { get; set; }
        public string BusinessName { get; set; }
        public string DeliveredTo { get; set; }
        public string ItemType { get; set; }
        public string CheckNo { get; set; }
        public string RecievedBy { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime ProcessedDate { get; set; }

    }
}
