using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_TmsRDCInformation
    {
        public int HistoryId { get; set; }
        public int Rdcid { get; set; }
        public int ClientNumber { get; set; }
        public string ClientName { get; set; }
        public string OfficerName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? NextReviewDate { get; set; }
        public string RiskRate { get; set; }
        public DateTime? CustomerSince { get; set; }
        public decimal? YearsInBusiness { get; set; }
        public string PortfolioNumber { get; set; }
        public string BusinessDescription { get; set; }
        public string Naicscode { get; set; }
        public decimal? WeightedApprovalLimit { get; set; }
        public decimal? HighestSettlement { get; set; }
        public decimal? HighestChargeback { get; set; }
        public decimal? AggChargeback { get; set; }
        public decimal? ChargebackCount { get; set; }
        public string NotesComments { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
    }
}
