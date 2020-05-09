using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_ProductCodes
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
