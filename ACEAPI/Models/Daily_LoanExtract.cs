using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Daily_LoanExtract
    {
        public string StatusCodeFullDesc { get; set; }
        public string NameId { get; set; }
        public string TaxIdNumber { get; set; }
        public string LoanNumber { get; set; }
        public string LoanOfficerCode { get; set; }
        public string LoanOfficer { get; set; }
        public decimal? OriginalBalance { get; set; }
        public DateTime? OriginalNoteDate { get; set; }
        public decimal? RenewalBalance { get; set; }
        public DateTime? RenewalDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? BookBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? AvailableCredit { get; set; }
        public decimal? TotalCommitted { get; set; }
        public decimal? CurrentInterestMethod { get; set; }
        public string AmortizationDays { get; set; }
        public decimal? InterestRate { get; set; }
        public string InterestRateType { get; set; }
        public string VariableRateIndex { get; set; }
        public decimal? RateChangePrevIndexRate { get; set; }
        public decimal? RateAdjuster { get; set; }
        public decimal? TotalInterestRate { get; set; }
        public decimal? RemainingTerm { get; set; }
        public string WatchList { get; set; }
        public string Tdr { get; set; }
        public string NonAccrual { get; set; }
        public DateTime? NonAccrualDate { get; set; }
        public decimal? MaximumDaysPastDue { get; set; }
        public decimal? TimesPastDue30To59Days { get; set; }
        public decimal? TimesPastDue60To89Days { get; set; }
        public decimal? TimesPastDueOver90Days { get; set; }
        public decimal? CurrYtdInterest { get; set; }
        public decimal? FairValuePremiumDiscount { get; set; }
        public string GovernmentGuaranteed { get; set; }
        public decimal? GuaranteedPercent { get; set; }
        public decimal? GuaranteedAmount { get; set; }
        public string CallReportCode { get; set; }
        public decimal? CollateralCode { get; set; }
        public string CollateralCodeDesc { get; set; }
        public decimal? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string AlllSegmentation { get; set; }
        public string SecondarySegmentation { get; set; }
        public decimal? MsaCode { get; set; }
        public string MsaCodeDesc { get; set; }
        public decimal? NaicsCode { get; set; }
        public string NaicsDescription { get; set; }
        public string Zip { get; set; }
        public decimal? AccountingGroup { get; set; }
        public string AccountingGroupDesc { get; set; }
        public decimal? FloorRate { get; set; }
        public decimal? CeilingRate { get; set; }
        public decimal? TimesRenewedExtended { get; set; }
        public string BorrowersAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CollateralAddress { get; set; }
        public string ClassCode { get; set; }
        public decimal? TotalAmountPastDue { get; set; }
        public decimal? Portfolio { get; set; }
        public decimal? GlSegment { get; set; }
        public decimal? PurposeCode { get; set; }
        public string PurposeCodeDesc { get; set; }
        public string Participations { get; set; }
        public string FasType { get; set; }
        public decimal? RegPaymentPIAmount { get; set; }
        public string RegularPaymentFrequency { get; set; }
        public DateTime? DateLastPayment { get; set; }
        public decimal? AmountLastPayment { get; set; }
        public decimal? LoanRatingCode1 { get; set; }
        public string LoanRatingCode1FullDesc { get; set; }
        public string PaymentType { get; set; }
        public decimal? NetUnearnedDeferredFees { get; set; }
        public decimal? Interest { get; set; }
        public decimal? NetNonAccrualPaidInterest { get; set; }
        public decimal? MiscellaneousCode { get; set; }
        public string PurchasedLoans { get; set; }
    }
}
