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
    internal class LineItemAttrModel
    {
        public const string MethodSELECTED = "SELECTED";
        public const string MethodGENERATED = "GENERATED";
        public string LineItemAttrID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Method { get; set; }
        public string AttributeDataType { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeUnits { get; set; }
        public string ShowOnQuote { get; set; }

        /////////////////////////////////////////////////////////////////////////////////
        // Constructor
        /////////////////////////////////////////////////////////////////////////////////
        public LineItemAttrModel()
        {
            LineItemAttrID = Guid.NewGuid().ToString().ToUpper();
            Name = "";
            Description = "";
            Method = MethodSELECTED;
            AttributeDataType = "";
            AttributeValue = "";
            AttributeUnits = "";
            ShowOnQuote = "Y";
        }

    }
}
