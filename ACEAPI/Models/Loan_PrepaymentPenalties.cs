using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_PrepaymentPenalties
    {
        public string PrepaymentValue { get; set; }
        public string PrepaymentDisplay { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
