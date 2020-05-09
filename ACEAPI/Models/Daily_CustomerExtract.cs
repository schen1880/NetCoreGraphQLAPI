using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Daily_CustomerExtract
    {
        public string Portfolio { get; set; }
        public string NameId { get; set; }
        public string PrimaryName { get; set; }
        public string ShortFirstName { get; set; }
        public string ShortLastName { get; set; }
        public string TaxIdCodeDescription { get; set; }
        public string TaxIdDescription { get; set; }
        public string CustomerType { get; set; }
        public string ResponsibilityCodeFullDesc { get; set; }
        public string NaicsCode { get; set; }
        public string NaicsDescription { get; set; }
        public decimal? AccountingBranch { get; set; }
        public string AccountingBranchDescription { get; set; }
        public string AccountAddress { get; set; }
        public string AccountAddress2 { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string AccountZip { get; set; }
        public string BusinessPhone { get; set; }
        public string CellularPhone { get; set; }
        public string HomePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string FormattedTaxId { get; set; }
        public string AnnualGrossRevenue { get; set; }
        public string Occupation { get; set; }
    }
}
