using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_BackupData121919
    {
        public int DocumentId { get; set; }
        public int LoanId { get; set; }
        public string TaxIdssn { get; set; }
        public string DocumentName { get; set; }
        public string DocumentIdentifier { get; set; }
        public string DocumentClassification { get; set; }
        public int? IsRequired { get; set; }
        public string LastSavedBy { get; set; }
    }
}
