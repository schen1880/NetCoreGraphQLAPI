using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class VwTrackingDocuments
    {
        public string Ck { get; set; }
        public string DocumentName { get; set; }
        public string DocumentIdentifier { get; set; }
        public string DocumentClassification { get; set; }
        public bool? IsRequired { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string DocumentUrl { get; set; }
        public long? Row { get; set; }
        public string NotesComments { get; set; }
    }
}
