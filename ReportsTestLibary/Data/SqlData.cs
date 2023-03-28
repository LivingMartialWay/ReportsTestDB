using ReportsTestLibary.Models;
using ReportsTestLibrary.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsTestLibary.Data
{
    public class SqlData : IDatabaseData
    {
        private readonly IDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(IDataAccess db)
        {
            _db = db;

        }

      
        public List<DropOffModel> GetDropOffRecordList(DateTime startDate, DateTime endDate)
       {
           return _db.LoadData<DropOffModel, dynamic>("select * from dbo.ReportTestTable r where @startDate <= r.DeliveredWhen and @endDate >= r.DeliveredWhen",
                                               new { startDate, endDate },
                                              "SqlDb",
                                              false);
        }



        public List<DropOffModel> GetDropOffRecordSingle(int RecNo)
        {
            return _db.LoadData<DropOffModel, dynamic>("select * from dbo.ReportTestTable r where r.RecNo = @RecNo",
                                                 new { RecNo },
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
                                 string recievedBy,
                                 string processedBy,
                                 DateTime processedDate
                                 )
        {
            _db.SaveData("INSERT INTO dbo.ReportTestTable (DeliveryType, DeliveredWhen, DeliveredBy, BusinessName, DeliveredTo, ItemType, CheckNo, RecievedBy, ProcessedBy, ProcessedDate) VALUES (@deliveryType, @deliveredWhen, @deliveredBy, @businessName, @deliveredTo, @itemType, @checkNo, @recievedBy, @processedBy, @processedDate)",
                         new
                         {
                             deliveryType = deliveryType,
                             recievedBy = recievedBy,
                             deliveredWhen = deliveredWhen,
                             deliveredby = deliveredby,
                             businessName = businessName,
                             deliveredTo = deliveredTo,
                             itemType = itemType,
                             checkNo = checkNo,
                             processedBy = processedBy,
                             processedDate = processedDate
                         },
                         connectionStringName,
                         false);
        }




        public void UpdateRecord(int RecNo,
                                 string deliveryType,
                                 DateTime deliveredWhen,
                                 string deliveredby,
                                 string businessName,
                                 string deliveredTo,
                                 string itemType,
                                 string checkNo,
                                 string recievedBy,
                                 string processedBy,
                                 DateTime processedDate
                                 )
        {
        _db.SaveData("UPDATE dbo.ReportTestTable SET DeliveryType = @deliveryType, DeliveredWhen = @deliveredWhen, DeliveredBy = @deliveredBy, BusinessName = @businessName, DeliveredTo =dTo, ItemType = @itemType, CheckNo = @checkNo, RecievedBy = @recievedBy, ProcessedBy = @processedBy, ProcessedDate = @processedDate WHERE @RecNo = RecNo",
                         new
                         {   RecNo,
                             deliveryType = deliveryType,
                             recievedBy = recievedBy,
                             deliveredWhen = deliveredWhen,
                             deliveredby = deliveredby,
                             businessName = businessName,
                             deliveredTo = deliveredTo,
                             itemType = itemType,
                             checkNo = checkNo,
                             processedBy = processedBy,
                             processedDate = processedDate
                         },
                         connectionStringName,
                         false) ;


        }
    }
}
