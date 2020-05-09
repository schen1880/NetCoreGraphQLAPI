using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_SubjectTo
    {
        public long HistoryId { get; set; }
        public int SubjectToId { get; set; }
        public int LoanId { get; set; }
        public string SubjectToDescription { get; set; }
    }
}
