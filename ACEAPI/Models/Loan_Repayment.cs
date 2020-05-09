using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_Repayment
    {
        public int RepaymentId { get; set; }
        public int LoanId { get; set; }
        public string Amortization { get; set; }
        public string Term { get; set; }
        public string TermUnit { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? FirstPaymentDate { get; set; }
        public string InterestCalculationMethod { get; set; }
        public string Escrow { get; set; }
        public string Structure { get; set; }
        public string RepaymentProgram { get; set; }
        public string NumberOfPayments { get; set; }
        public string PaymentsDue { get; set; }
        public string AutoDebit { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string PaymentAmount { get; set; }
        public string PaymentFrequency { get; set; }
        public string BankName { get; set; }
        public string PaymentChangeFrequency { get; set; }
        public string PrimarySourceRepayment { get; set; }
        public string SecondarySourceRepayment { get; set; }
        public string TertiarySourceRepayment { get; set; }
        public string RepaymentComments { get; set; }
        public string Prepayment { get; set; }
        public string PrepaymentOther { get; set; }
        public string OtherPaymentInfo { get; set; }
    }
}
