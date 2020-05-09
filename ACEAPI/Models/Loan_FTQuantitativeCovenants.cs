using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_FTQuantitativeCovenants
    {
        public long Ftqcid { get; set; }
        public int LoanId { get; set; }
        public int ObligorId { get; set; }
        public string DocumentName { get; set; }
        public decimal? RatioRequired { get; set; }
        public decimal? RatioActual { get; set; }
        public string Sqfrequency { get; set; }
        public string Sqannual { get; set; }
        public string Sqinterim { get; set; }
        public DateTime? SqasOfDate { get; set; }
        public bool? IsStandard { get; set; }
        public string Qccomments { get; set; }
    }
}
