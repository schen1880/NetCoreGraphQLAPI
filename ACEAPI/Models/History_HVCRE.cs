using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_HVCRE
    {
        public long HistoryId { get; set; }
        public int Hvcreid { get; set; }
        public int LoanId { get; set; }
        public bool? IsHvcre { get; set; }
    }
}
