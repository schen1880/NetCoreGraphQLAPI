using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_HMDACodes
    {
        public string Hmdacode { get; set; }
        public string Hmdadescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
