using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_HMDA
    {
        public int Hmdaid { get; set; }
        public int LoanId { get; set; }
        public bool? IsHmda { get; set; }
        public string Hmdacode { get; set; }
    }
}
