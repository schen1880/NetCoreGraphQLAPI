using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Cip_CIP
    {
        public int Cipid { get; set; }
        public string TaxIdssn { get; set; }
        public string TaxIdssntype { get; set; }
        public string PrimaryName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Idtype { get; set; }
        public string IdstateCountry { get; set; }
        public string Idnumber { get; set; }
        public DateTime? IdissueDate { get; set; }
        public DateTime? IdexpirationDate { get; set; }
        public string SecondaryIdtype { get; set; }
        public string SecondaryIdstateCountry { get; set; }
        public string SecondaryIdnumber { get; set; }
        public DateTime? SecondaryIdissueDate { get; set; }
        public DateTime? SecondaryIdexpirationDate { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalCountry { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalState { get; set; }
        public string PhysicalPostalCode { get; set; }
        public string MailingAddress1 { get; set; }
        public string MailingAddress2 { get; set; }
        public string MailingCountry { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
    }
}
