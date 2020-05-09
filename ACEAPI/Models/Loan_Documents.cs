using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_Documents
    {
        public long DocumentId { get; set; }
        public int LoanId { get; set; }
        public string TaxIdssn { get; set; }
        public string DocumentName { get; set; }
        public string DocumentIdentifier { get; set; }
        public string DocumentClassification { get; set; }
        public bool? IsRequired { get; set; }
        public string LastSavedBy { get; set; }
    }
}
