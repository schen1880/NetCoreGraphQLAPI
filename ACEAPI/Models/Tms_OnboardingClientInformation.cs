using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Tms_OnboardingClientInformation
    {
        public int OnboardingId { get; set; }
        public int? ClientNumber { get; set; }
        public string TaxIdSsn { get; set; }
        public string TaxIdSsntype { get; set; }
        public string ClientName { get; set; }
        public string OfficerName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? NextReviewDate { get; set; }
        public string RiskRate { get; set; }
        public DateTime? CustomerSince { get; set; }
        public decimal? YearsInBusiness { get; set; }
        public string PortfolioNumber { get; set; }
        public string BusinessDescription { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string Naicscode { get; set; }
        public string Achstatus { get; set; }
        public string Rdcstatus { get; set; }
        public string NotesComments { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
        public int? ProcessId { get; set; }
        public string Tmanalyst { get; set; }
        public string Tmsales { get; set; }
    }
}
