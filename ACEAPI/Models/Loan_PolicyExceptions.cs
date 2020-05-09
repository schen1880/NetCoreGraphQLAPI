using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_PolicyExceptions
    {
        public int ExceptionId { get; set; }
        public int LoanId { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionDetail { get; set; }
        public string ExceptionFactors { get; set; }
    }
}
