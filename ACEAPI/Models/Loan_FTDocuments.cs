using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_FTDocuments
    {
        public string DocumentName { get; set; }
        public bool? FinancialStatements { get; set; }
        public bool? QuantitativeCovenants { get; set; }
        public bool? BorrowingBase { get; set; }
        public bool? BorrowingBaseIneligibles { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
