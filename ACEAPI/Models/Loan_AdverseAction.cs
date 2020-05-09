using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_AdverseAction
    {
        public int AdverseActionId { get; set; }
        public int LoanId { get; set; }
        public string Aareason { get; set; }
        public DateTime? Aadate { get; set; }
        public string Aadetails { get; set; }
    }
}
