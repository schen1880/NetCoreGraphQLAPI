using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_LendingOfficers
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactPhone { get; set; }
        public string Title { get; set; }
        public decimal? AuthorityLevel { get; set; }
        public decimal? TotalAuthority { get; set; }
        public string ResponsibilityCode { get; set; }
        public string BranchCode { get; set; }
        public string RegionCode { get; set; }
        public string MarketCode { get; set; }
    }
}
