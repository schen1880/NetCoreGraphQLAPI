using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_FrequencyCodes
    {
        public string FrequencyCode { get; set; }
        public string FrequencyDisplay { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
