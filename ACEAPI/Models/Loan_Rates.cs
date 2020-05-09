using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_Rates
    {
        public int RateId { get; set; }
        public int LoanId { get; set; }
        public bool? RateFixed { get; set; }
        public string InterestRate { get; set; }
        public string RateIndex { get; set; }
        public string FloorRate { get; set; }
        public string CeilingRate { get; set; }
        public string Margin { get; set; }
        public string RateChangeFrequency { get; set; }
        public string RateChangeMemo { get; set; }
        public bool? CustomerSelected { get; set; }
    }
}
