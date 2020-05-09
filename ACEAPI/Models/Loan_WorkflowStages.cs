using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_WorkflowStages
    {
        public string StageGateName { get; set; }
        public string ActivityName { get; set; }
        public int StageGateNumber { get; set; }
        public int ActivityNumber { get; set; }
    }
}
