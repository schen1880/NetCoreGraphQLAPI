using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_LendingOfficerAuthority
    {
        public int AuthorityId { get; set; }
        public string Username { get; set; }
        public short DebtTypeCode { get; set; }
        public decimal AuthorityAmount { get; set; }
    }
}
