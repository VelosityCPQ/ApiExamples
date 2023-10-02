using Microsoft.VisualBasic;
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
    internal class LineItemModel
    {
        public const string StatusNEW = "NEW";
        public const string StatusWIP = "WIP";
        public const string StatusFINISHED = "FINISHED";
        public const string StatusSHIPPED = "SHIPPED";
        public string LineItemID { get; set; }
        public int LineNumber { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }  // lineitem...not Quote!
        public string Status { get; set; }
        public List<LineItemAttrModel> Attributes { get; set; }
        public List<LineItemTaskModel> Tasks { get; set; }
        public bool AllowDiscount { get; set; }
        public string LengthUOM { get; set; }
        public string WeightUOM { get; set; }
        public string ShowSubTotal { get; set; } // after
        public string SerializationRequired { get; set; }

        // Dimensions for shipping
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public LineItemModel()
        {
            LineItemID = Guid.NewGuid().ToString().ToUpper();

            ProductName = "New";
            Description = "New";

            Attributes = new List<LineItemAttrModel>();
            Tasks = new List<LineItemTaskModel>();

            Quantity = 1;
            Discount = 0;
            ShowSubTotal = "N";
            AllowDiscount = true;
            SerializationRequired = "N";

            Status = StatusNEW;

            LengthUOM = "IN";
            WeightUOM = "LB";

            // In Instance units system!!!
            Weight = 0;
            Length = 0;
            Width = 0;
            Height = 0;

        }

    }
}
