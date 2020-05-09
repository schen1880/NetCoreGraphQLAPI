using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Document_RequiredDocumentsByStageGate
    {
        public string DocumentName { get; set; }
        public string DocumentClassification { get; set; }
        public string WorkflowStageGate { get; set; }
        public string WorkflowActivity { get; set; }
        public bool? AllowPending { get; set; }
    }
}
