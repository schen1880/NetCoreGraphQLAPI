using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_RequestTypes
    {
        public string RequestType { get; set; }
        public string RequestTypeDisplay { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
