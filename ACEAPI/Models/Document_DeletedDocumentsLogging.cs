using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Document_DeletedDocumentsLogging
    {
        public int ProcessId { get; set; }
        public string UploadedDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentIdentifier { get; set; }
        public string TaxIdSsn { get; set; }
        public string LoanNumber { get; set; }
        public string DocumentUrl { get; set; }
        public string DeletedByUserName { get; set; }
        public DateTime? DeletedTimeStamp { get; set; }
    }
}
