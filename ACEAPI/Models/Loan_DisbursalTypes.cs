using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_DisbursalTypes
    {
        public int DisbursalTypeId { get; set; }
        public string DisbursalType { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
