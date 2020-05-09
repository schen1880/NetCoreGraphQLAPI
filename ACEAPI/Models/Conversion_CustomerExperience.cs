using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Conversion_CustomerExperience
    {
        public int Cxid { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedTimestamp { get; set; }
        public string FunctionalArea { get; set; }
        public string FunctionalSegment { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public string TaxIdssn { get; set; }
        public string PortfolioNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Criticality { get; set; }
        public string RelationshipManager { get; set; }
        public string ResolutionNotes { get; set; }
        public string Approvals { get; set; }
        public string AdditionalNotes { get; set; }
        public string ProcessId { get; set; }
        public string Status { get; set; }
    }
}
