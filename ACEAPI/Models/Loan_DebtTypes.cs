using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_DebtTypes
    {
        public short DebtTypeCode { get; set; }
        public string DebtTypeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
