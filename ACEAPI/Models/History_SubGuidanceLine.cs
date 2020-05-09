using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_SubGuidanceLine
    {
        public long HistoryId { get; set; }
        public int SubGuidanceLineId { get; set; }
        public int LoanId { get; set; }
        public string SubOrdinal { get; set; }
        public string MasterLoanNumber { get; set; }
    }
}
