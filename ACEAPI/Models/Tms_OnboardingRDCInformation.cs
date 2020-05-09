using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Tms_OnboardingRDCInformation
    {
        public int OnboardingRdcid { get; set; }
        public int OnboardingId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Status { get; set; }
        public decimal? HighestSettlement { get; set; }
        public decimal? AggChargeback { get; set; }
        public decimal? ChargebackCount { get; set; }
        public decimal? RdcweightedRiskExposure { get; set; }
        public decimal? RdcdailyLimit { get; set; }
        public string RdcriskRate { get; set; }
        public string NotesComments { get; set; }
    }
}
