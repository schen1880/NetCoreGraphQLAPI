using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_RelationshipEnhancementOpportunitiesNotes
    {
        public int ReonoteId { get; set; }
        public int ProspectId { get; set; }
        public string BusinessUnit { get; set; }
        public string NoteUser { get; set; }
        public DateTime? NoteTimestamp { get; set; }
        public string NoteDetails { get; set; }
    }
}
