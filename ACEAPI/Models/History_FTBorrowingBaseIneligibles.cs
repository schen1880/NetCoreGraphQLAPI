using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_FTBorrowingBaseIneligibles
    {
        public long HistoryId { get; set; }
        public long Ftbbiid { get; set; }
        public int LoanId { get; set; }
        public int ObligorId { get; set; }
        public string DocumentName { get; set; }
        public string Bbicomments { get; set; }
    }
}
