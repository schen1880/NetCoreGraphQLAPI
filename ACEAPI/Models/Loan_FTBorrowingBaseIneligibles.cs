using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_FTBorrowingBaseIneligibles
    {
        public long Ftbbiid { get; set; }
        public int LoanId { get; set; }
        public int ObligorId { get; set; }
        public string DocumentName { get; set; }
        public string Bbicomments { get; set; }
    }
}
