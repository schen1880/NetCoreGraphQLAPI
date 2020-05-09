using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class VwAchrdcportfolio
    {
        public string OfficerName { get; set; }
        public int? Active { get; set; }
        public int? Pending { get; set; }
        public int? PastDue { get; set; }
    }
}
