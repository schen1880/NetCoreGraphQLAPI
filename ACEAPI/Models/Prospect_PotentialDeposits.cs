using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_PotentialDeposits
    {
        public int DepositId { get; set; }
        public int ProspectId { get; set; }
        public string DepositType { get; set; }
        public decimal? DepositAmount { get; set; }
    }
}
