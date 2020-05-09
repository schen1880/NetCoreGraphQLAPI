using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Prospect_ContactMethods
    {
        public int ContactId { get; set; }
        public int ProspectId { get; set; }
        public string ContactName { get; set; }
        public string ContactMethod { get; set; }
        public string ContactValue { get; set; }
    }
}
