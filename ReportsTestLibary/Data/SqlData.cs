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

        public void CreateRecord(string deliveryType,
                                 DateTime deliveredWhen,
                                 string deliveredby,
                                 string businessName,
                                 string deliveredTo,
                                 string itemType,
                                 string checkNo,
                                 string recievedBy
                                 )
        {
            // INSERT INTO ReportTestTable (DeliveryType, DeliveredWhen, DeliveredBy, BusinessName, DeliveredTo, ItemType, CheckNo, RecievedBy)
            // VALUES (@deliveryType, @deliveredWhen, @deliveredby, @businessName, @deliveredTo, @itemType, @checkNo, @recievedBy);

        }
    }
}
