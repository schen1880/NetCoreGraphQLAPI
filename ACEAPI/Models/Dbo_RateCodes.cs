using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_RateCodes
    {
        public short RateCode { get; set; }
        public string RateDescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
    }
}
