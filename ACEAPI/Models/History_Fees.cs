using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_Fees
    {
        public long HistoryId { get; set; }
        public int FeeId { get; set; }
        public int LoanId { get; set; }
        public string FeeTypeCode { get; set; }
        public decimal? AmountFinanced { get; set; }
        public decimal? AmountCash { get; set; }
        public decimal? AmountBankPaid { get; set; }
        public string OtherDesc { get; set; }
        public string FeeCollection { get; set; }
        public string FixedOrPercent { get; set; }
    }
}
