using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportsTestLibary.Models;

namespace ReportsTestLibary.Data
{
    public interface IDatabaseData
    {
        void CreateRecord(string deliveryType,
                                 DateTime deliveredWhen,
                                 string deliveredby,
                                 string businessName,
                                 string deliveredTo,
                                 string itemType,
                                 string checkNo,
                                 string recievedBy,
                                 string processedBy,
                                 DateTime processedDate
                                 );

        List<DropOffModel> GetDropOffRecordSingle(int RecNo);

        List<DropOffModel> GetDropOffRecordList(DateTime startDate, DateTime endDate);

        void UpdateRecord(int RecNo,
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
                                 );
   //     void UpdateRecord(int RecNo, string deliveryType, DateTime deliveredWhen, string deliveredBy, string businessName, string deliveredTo, string itemType, string checkNo, string recievedBy, string processedBy, DateTime processedDate);
    }
}
