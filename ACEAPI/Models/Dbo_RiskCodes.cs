using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_RiskCodes
    {
        public short RiskCode { get; set; }
        public string RiskDescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
