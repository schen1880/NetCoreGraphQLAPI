using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_RelationshipEnhancementOpportunities
    {
        public int Reoid { get; set; }
        public int ProspectId { get; set; }
        public string BusinessUnit { get; set; }
        public DateTime? TargetCallDate { get; set; }
        public string OpportunitySummary { get; set; }
        public bool? EmailSent { get; set; }
    }
}
