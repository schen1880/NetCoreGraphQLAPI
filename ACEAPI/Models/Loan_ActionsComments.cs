using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_ActionsComments
    {
        public long ActionCommentId { get; set; }
        public int LoanId { get; set; }
        public string Username { get; set; }
        public DateTime? ActionCommentTimestamp { get; set; }
        public string WorkflowStage { get; set; }
        public string WorkflowActivity { get; set; }
        public string SelectedAction { get; set; }
        public string NotesComments { get; set; }
    }
}
