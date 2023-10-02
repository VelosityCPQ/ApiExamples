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
    internal class PackingListSalesItemModel
    {
        public string PackingListItemID { get; set; }
        public string SalesOrderID { get; set; }
        public string SalesItemAndQtyID { get; set; }
        public int QuantityToShip { get; set; }
        public int QuantityShipped { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public PackingListSalesItemModel()
        {
            PackingListItemID = Guid.NewGuid().ToString().ToUpper();
            SalesOrderID = "";
            SalesItemAndQtyID = "";

            QuantityToShip = 0;
            QuantityShipped = 0;
        }
    }
}
