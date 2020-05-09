using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Document_MultipleTaxIds
    {
        public int Id { get; set; }
        public int UploadedDocumentId { get; set; }
        public string TaxIdSsn { get; set; }
        public bool? IsProcessed { get; set; }
    }
}
