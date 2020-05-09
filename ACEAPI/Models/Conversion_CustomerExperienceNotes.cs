using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Conversion_CustomerExperienceNotes
    {
        public int NoteId { get; set; }
        public int Cxid { get; set; }
        public string NoteComment { get; set; }
        public string NoteUser { get; set; }
        public DateTime? NoteTimestamp { get; set; }
    }
}
