﻿using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_TmsACHInformation
    {
        public int HistoryId { get; set; }
        public int Achid { get; set; }
        public int ClientNumber { get; set; }
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
        public decimal? DemandBalance { get; set; }
        public decimal? CertificateBalance { get; set; }
        public decimal? DailyAchcredits { get; set; }
        public decimal? DailyAchdebits { get; set; }
        public decimal? MonthlyAchcredits { get; set; }
        public decimal? MonthlyAchdebits { get; set; }
        public string NotesComments { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
        public bool? IsPrimary { get; set; }
        public string AchcompanyId { get; set; }
    }
}
