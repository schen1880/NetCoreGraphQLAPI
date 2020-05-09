using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Dbo_EmployeeCodes
    {
        public string EmployeeCode { get; set; }
        public string EmployeeDescription { get; set; }
        public string CodeDescription { get; set; }
        public short? DisplayOrder { get; set; }
    }
}
