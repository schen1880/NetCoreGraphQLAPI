using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_SubjectTo
    {
        public int SubjectToId { get; set; }
        public int LoanId { get; set; }
        public string SubjectToDescription { get; set; }
    }
}
