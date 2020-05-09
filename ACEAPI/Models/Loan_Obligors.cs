using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_Obligors
    {
        public int ObligorId { get; set; }
        public int LoanId { get; set; }
        public string EntityTypeType { get; set; }
        public string EntityType { get; set; }
        public string ObligorType { get; set; }
        public string TaxIdssn { get; set; }
        public string TaxIdssntype { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryOccupation { get; set; }
        public string JobTitle { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string EmailAddress { get; set; }
        public string OwnershipType { get; set; }
        public string OwnershipAmount { get; set; }
        public string GuarantyType { get; set; }
        public string GuarantyTypeDetails { get; set; }
        public bool? JointCredit { get; set; }
        public bool? GuarantorRequired { get; set; }
        public decimal? AnnualIncome { get; set; }
        public string IncomeType { get; set; }
        public string BeneficialOwnerDetails { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalCountry { get; set; }
        public string PhysicalState { get; set; }
        public string PhysicalPostalCode { get; set; }
        public string MailingAddress1 { get; set; }
        public string MailingAddress2 { get; set; }
        public string MailingCity { get; set; }
        public string MailingCountry { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }
        public short? Caporder { get; set; }
        public bool? ActiveMilitary { get; set; }
        public bool? Pep { get; set; }
        public bool? Burnout { get; set; }
        public string BurnoutDescription { get; set; }
    }
}
