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
    internal class LineItemTaskModel
    {
        public string LineItemTaskID { get; set; }
        public string WorkCenter { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int TaskNumber { get; set; }
        public string PricingComponent { get; set; }
        public decimal TimeSetup_min { get; set; }
        public decimal TimeTeardown_min { get; set; }
        public decimal TimeTransfer_min { get; set; }
        public decimal Time_MIN { get; set; }
        public decimal Cost_CUR { get; set; }
        public decimal Price_CUR { get; set; }      // gross
        public List<string> Information { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        // Constructor
        /////////////////////////////////////////////////////////////////////////////////
        public LineItemTaskModel()
        {
            LineItemTaskID = Guid.NewGuid().ToString().ToUpper();
            Information = new List<string>();
            Detail = "";
            PricingComponent = "";
            WorkCenter = "";
            Name = "";

            TimeSetup_min = 0;
            TimeTeardown_min = 0;
            TimeTransfer_min = 0;
        }

    }
}
