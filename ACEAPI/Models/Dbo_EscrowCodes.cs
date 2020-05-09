using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_EscrowCodes
    {
        public string EscrowCode { get; set; }
        public string EscrowDescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
