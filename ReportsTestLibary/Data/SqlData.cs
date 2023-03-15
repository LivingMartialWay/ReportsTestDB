using HotelAppLibrary.Databases;
using ReportsTestLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsTestLibary.Data
{
    public class SqlData
    {
        private readonly IDataAccess _db;

        public SqlData(IDataAccess db)
        {
            _db = db;

        }

        public List<DropOffModel> GetDropOffRecord(DateTime startDate, DateTime endDate)
        {
           return _db.LoadData<DropOffModel, dynamic>("select * from dbo.ReportTestTable r where @startDate <= r.DeliveredWhen and @endDate >= r.DeliveredWhen",
                                                new { startDate, endDate },
                                                "SqlDb",
                                                false);
        }
    }
}
