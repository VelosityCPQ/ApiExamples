using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velosity_API_Demo
{
    /////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////
    internal class PackingListModel
    {
        public const string StatusDRAFT = "DRAFT";
        public const string StatusFINAL = "SHIPPED";
        public const string TypeWIP = "WIP";
        public const string TypeFINISHED = "FINISHED";
        public string PackingListID { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string ListType { get; set; }
        public string SalesOrderID { get; set; }
        public List<PackingListSalesLineModel> SalesLines { get; set; }
        public List<PackingListSalesItemModel> SalesItems { get; set; }
        public string CreatedByUserID { get; set; }
        public DateTime CreatedUTC { get; set; }
        public string LastUpdatedByUserID { get; set; }
        public DateTime LastUpdatedUTC { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public PackingListModel()
        {
            PackingListID = Guid.NewGuid().ToString().ToUpper();
            Number = "New";
            Status = StatusDRAFT;
            SalesOrderID = "";
            CreatedByUserID = "";
            LastUpdatedByUserID = "";

            ListType = TypeFINISHED;

            SalesLines = new List<PackingListSalesLineModel>();
            SalesItems = new List<PackingListSalesItemModel>();

            CreatedUTC = DateTime.UtcNow;
            LastUpdatedUTC = DateTime.UtcNow;

        }
    }
}
