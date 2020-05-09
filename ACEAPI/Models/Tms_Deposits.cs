using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Tms_Deposits
    {
        public int DepositId { get; set; }
        public int ClientNumber { get; set; }
        public string DepositType { get; set; }
        public decimal? DirectAmount { get; set; }
        public decimal? RelatedAmount { get; set; }
    }
}
