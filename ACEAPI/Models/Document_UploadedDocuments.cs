using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Document_UploadedDocuments
    {
        public int DocumentId { get; set; }
        public string LoanNumber { get; set; }
        public string TaxIdssn { get; set; }
        public string DocumentName { get; set; }
        public string DocumentClassification { get; set; }
        public string DocumentIdentifier { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string NotesComments { get; set; }
        public string DocumentUrl { get; set; }
        public string DocumentStatus { get; set; }
        public int? ProcessId { get; set; }
    }
}
