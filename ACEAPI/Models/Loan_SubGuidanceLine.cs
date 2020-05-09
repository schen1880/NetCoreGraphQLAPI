using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_SubGuidanceLine
    {
        public int SubGuidanceLineId { get; set; }
        public int LoanId { get; set; }
        public string SubOrdinal { get; set; }
        public string MasterLoanNumber { get; set; }
    }
}
