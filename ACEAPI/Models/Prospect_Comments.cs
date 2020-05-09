using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_Comments
    {
        public int CommentId { get; set; }
        public int ProspectId { get; set; }
        public string CommentUser { get; set; }
        public DateTime? CommentTimestamp { get; set; }
        public string CommentDetails { get; set; }
        public DateTime? CallDate { get; set; }
    }
}
