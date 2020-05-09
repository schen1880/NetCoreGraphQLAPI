using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_FTFinancialStatements
    {
        public long HistoryId { get; set; }
        public long Ftfsid { get; set; }
        public int LoanId { get; set; }
        public int ObligorId { get; set; }
        public string DocumentName { get; set; }
        public string ReportingFrequency { get; set; }
        public string GracePeriod { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Fscomments { get; set; }
    }
}
