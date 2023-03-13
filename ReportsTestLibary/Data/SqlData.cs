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
           return _db.LoadData<DropOffModel, dynamic>("dbo.spDropOffLog_GetRecords",
                                                new { startDate, endDate },
                                                "SqlDb",
                                                true);
        }
    }
}
