using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Document_Taxonomy
    {
        public string DocumentName { get; set; }
        public string DocumentClassification { get; set; }
        public string DocumentType { get; set; }
        public byte SecondaryIndexingRoute { get; set; }
    }
}
