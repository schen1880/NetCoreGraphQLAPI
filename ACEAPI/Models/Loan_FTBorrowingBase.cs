using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_FTBorrowingBase
    {
        public long Ftbbid { get; set; }
        public int LoanId { get; set; }
        public int ObligorId { get; set; }
        public string DocumentName { get; set; }
        public decimal? AdvRates { get; set; }
        public decimal? MaxConcentration { get; set; }
        public string Frequency { get; set; }
        public string Ineligible { get; set; }
        public bool? IsLockbox { get; set; }
        public string Bbcomments { get; set; }
    }
}
