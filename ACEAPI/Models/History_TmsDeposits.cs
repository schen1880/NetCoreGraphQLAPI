using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_TmsDeposits
    {
        public int HistoryId { get; set; }
        public int DepositId { get; set; }
        public int ClientNumber { get; set; }
        public string DepositType { get; set; }
        public decimal? DirectAmount { get; set; }
        public decimal? RelatedAmount { get; set; }
    }
}
