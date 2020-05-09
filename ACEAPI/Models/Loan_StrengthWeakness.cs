using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_StrengthWeakness
    {
        public int LoanSwid { get; set; }
        public int LoanId { get; set; }
        public string StrengthOrWeakness { get; set; }
        public string LoanSwdescription { get; set; }
    }
}
