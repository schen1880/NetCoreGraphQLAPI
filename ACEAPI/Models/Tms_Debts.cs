using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Tms_Debts
    {
        public int DebtId { get; set; }
        public int ClientNumber { get; set; }
        public short? DebtTypeCode { get; set; }
        public decimal? DirectCommittedAmount { get; set; }
        public decimal? RelatedCommittedAmount { get; set; }
        public decimal? NewRequestAmount { get; set; }
        public decimal? OfficerLimit { get; set; }
    }
}
