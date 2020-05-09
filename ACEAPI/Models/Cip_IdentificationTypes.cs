using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Cip_IdentificationTypes
    {
        public string Idtype { get; set; }
        public string Iddisplay { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsSecondary { get; set; }
    }
}
