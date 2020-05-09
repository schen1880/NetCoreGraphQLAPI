using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_Deposits
    {
        public long HistoryId { get; set; }
        public int DepositId { get; set; }
        public int LoanId { get; set; }
        public string DepositType { get; set; }
        public decimal? DirectAmount { get; set; }
        public decimal? RelatedAmount { get; set; }
    }
}
