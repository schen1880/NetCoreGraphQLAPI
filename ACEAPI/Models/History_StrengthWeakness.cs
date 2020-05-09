using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_StrengthWeakness
    {
        public long HistoryId { get; set; }
        public int LoanSwid { get; set; }
        public int LoanId { get; set; }
        public string StrengthOrWeakness { get; set; }
        public string LoanSwdescription { get; set; }
    }
}
