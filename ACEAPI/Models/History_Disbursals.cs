using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_Disbursals
    {
        public long HistoryId { get; set; }
        public int DisbursalId { get; set; }
        public int LoanId { get; set; }
        public string DisbursalName { get; set; }
        public DateTime? DisbursalDate { get; set; }
        public decimal? DisbursalAmount { get; set; }
        public string DisbursalType { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string DisbursalComments { get; set; }
    }
}
