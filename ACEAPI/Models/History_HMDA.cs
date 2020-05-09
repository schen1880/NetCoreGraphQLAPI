using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_HMDA
    {
        public long HistoryId { get; set; }
        public int Hmdaid { get; set; }
        public int LoanId { get; set; }
        public bool? IsHmda { get; set; }
        public string Hmdacode { get; set; }
    }
}
