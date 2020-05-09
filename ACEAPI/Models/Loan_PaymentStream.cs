using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_PaymentStream
    {
        public int PaymentStreamId { get; set; }
        public int LoanId { get; set; }
        public string NumberOfPayments { get; set; }
        public string Frequency { get; set; }
        public string Structure { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? EscrowAmount { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
