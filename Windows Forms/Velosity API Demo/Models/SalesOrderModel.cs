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
    internal class SalesOrderModel
    {
        public const string StatusTEST = "TEST";
        public const string StatusDRAFT = "DRAFT";
        public const string StatusRESERVED = "RESERVED";
        public const string StatusACCEPTED = "ACCEPTED";
        public const string StatusFINAL = "FINAL";
        public const string StatusCANCELLED = "CANCELLED";
        public const string StatusCOMPLETED = "COMPLETED";
        public const string StatusSHIPPEDPARTIAL = "SHIPPEDPARTIAL";
        public const string StatusSHIPPED = "SHIPPED";
        public const string StatusANY = "ANY";
        // FILTER
        public const string FilterMY = "MY";
        public const string FilterALL = "ALL";

        // PROPERTIES
        public string SalesOrderID { get; set; }
        public string SalesQuoteID { get; set; }
        // public CustomerModel Customer { get; set; }
        public string Status { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string PurchaseOrder { get; set; }
        // public string ExternalReference  { get; set; }
        public decimal DiscountPercent { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime PromiseDateUTC { get; set; }
        public string CreatedByUserID { get; set; }
        public string LastUpdatedByUserID { get; set; }
        public DateTime CreatedUTC { get; set; }
        public DateTime LastUpdatedUTC { get; set; }
        public List<LineItemModel> LineItems { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public SalesOrderModel()
        {
            SalesOrderID = Guid.NewGuid().ToString().ToUpper();

            Status = StatusDRAFT;
            Number = "New";
            Description = "";
            PurchaseOrder = "";
            SalesQuoteID = "";

            PromiseDateUTC = DateTime.UtcNow.AddDays(30);

            PaymentTerms = "Net 30 days";

            LineItems = new List<LineItemModel>();

            // Customer = new CustomerModel(CPQ.SystemUser());

            CreatedByUserID = "";
            CreatedUTC = DateTime.UtcNow;

            LastUpdatedByUserID = "";
            LastUpdatedUTC = DateTime.UtcNow;
        }

    }
}