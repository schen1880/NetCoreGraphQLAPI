using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_AvailableLoanNumbers
    {
        public string LoanNumber { get; set; }
        public bool? IsAssigned { get; set; }
        public string ClassificationCode { get; set; }
    }
}
