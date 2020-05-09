using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_ExceptionTypes
    {
        public int ExceptionId { get; set; }
        public string ExceptionType { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
