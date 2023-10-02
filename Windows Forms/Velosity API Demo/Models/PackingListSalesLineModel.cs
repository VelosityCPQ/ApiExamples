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
    internal class PackingListSalesLineModel
    {
        public string PackingListSalesLineID { get; set; }
        public string SalesOrderID { get; set; }
        public string SalesLineItemID { get; set; }
        public decimal QuantityToShip { get; set; }
        public decimal QuantityShipped { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public PackingListSalesLineModel()
        {
            PackingListSalesLineID = Guid.NewGuid().ToString().ToUpper();
            SalesOrderID = "";
            SalesLineItemID = "";
        }
    }
}
