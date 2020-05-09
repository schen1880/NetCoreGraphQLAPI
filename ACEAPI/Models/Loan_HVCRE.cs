using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_HVCRE
    {
        public int Hvcreid { get; set; }
        public int LoanId { get; set; }
        public bool? IsHvcre { get; set; }
    }
}
