using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_Prospects
    {
        public int ProspectId { get; set; }
        public string TaxIdssn { get; set; }
        public string TaxIdssntype { get; set; }
        public string LendingOfficer { get; set; }
        public string EntityType { get; set; }
        public string ProspectType { get; set; }
        public string PrimaryName { get; set; }
        public string PortfolioNumber { get; set; }
        public string Naicscode { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
    }
}
