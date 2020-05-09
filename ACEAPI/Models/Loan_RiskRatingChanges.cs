using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_RiskRatingChanges
    {
        public int RiskRatingChangeId { get; set; }
        public int LoanId { get; set; }
        public int? ProcessId { get; set; }
        public int CurrentRiskGrade { get; set; }
        public int ProposedRiskGrade { get; set; }
        public string ChangeExplanation { get; set; }
        public bool? IsConditionDeteriorated { get; set; }
        public bool? IsNotPaid { get; set; }
        public bool? IsPastDue { get; set; }
        public bool? IsAccrual { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool? IsApproved { get; set; }

        public virtual Loan_Loans Loan { get; set; }
    }
}
