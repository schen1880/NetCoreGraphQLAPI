using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_Loans
    {
        public int ProspectLoanId { get; set; }
        public int ProspectId { get; set; }
        public string DealName { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? InitialFundingAmount { get; set; }
        public string StageGate { get; set; }
        public string LoanType { get; set; }
        public byte? Probability { get; set; }
        public DateTime? LoanStartDate { get; set; }
        public DateTime? EstimatedClosingDate { get; set; }
        public string DealDescription { get; set; }
        public string WithdrawReason { get; set; }
        public DateTime? WithdrawDate { get; set; }
        public string WithdrawDetails { get; set; }
    }
}
