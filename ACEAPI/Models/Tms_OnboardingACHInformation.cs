using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Tms_OnboardingACHInformation
    {
        public int OnboardingAchid { get; set; }
        public int OnboardingId { get; set; }
        public string AchcompanyName { get; set; }
        public string TaxIdSsn { get; set; }
        public string TaxIdSsntype { get; set; }
        public decimal? DailyAchcredits { get; set; }
        public decimal? DailyAchdebits { get; set; }
        public decimal? MonthlyAchcredits { get; set; }
        public decimal? MonthlyAchdebits { get; set; }
        public string NotesComments { get; set; }
        public bool? IsPrimary { get; set; }
        public string AchcompanyId { get; set; }
    }
}
