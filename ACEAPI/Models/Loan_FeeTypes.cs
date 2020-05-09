using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_FeeTypes
    {
        public string FeeTypeCode { get; set; }
        public string FeeTypeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
