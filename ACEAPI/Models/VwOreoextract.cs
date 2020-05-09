using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class VwOreoextract
    {
        public string StatusCodeFullDesc { get; set; }
        public int? NameId { get; set; }
        public int? TaxIdNumber { get; set; }
        public string LoanNumber { get; set; }
        public string LoanOfficerCode { get; set; }
        public string LoanOfficer { get; set; }
        public decimal? OriginalBalance { get; set; }
        public int? OriginalNoteDate { get; set; }
        public int? RenewalBalance { get; set; }
        public int? RenewalDate { get; set; }
        public int? MaturityDate { get; set; }
        public int? BookBalance { get; set; }
        public int? CurrentBalance { get; set; }
        public int? AvailableCredit { get; set; }
        public int? TotalCommitted { get; set; }
        public int? CurrentInterestMethod { get; set; }
        public int? AmortizationDays { get; set; }
        public int? InterestRate { get; set; }
        public int? InterestRateType { get; set; }
        public int? VariableRateIndex { get; set; }
        public int? RateChangePrevIndexRate { get; set; }
        public int? RateAdjuster { get; set; }
        public int? TotalInterestRate { get; set; }
        public int? RemainingTerm { get; set; }
        public int? WatchList { get; set; }
        public int? Tdr { get; set; }
        public int? NonAccrual { get; set; }
        public int? NonAccrualDate { get; set; }
        public int? MaximumDaysPastDue { get; set; }
        public int? TimesPastDue30To59Days { get; set; }
        public int? TimesPastDue60To89Days { get; set; }
        public int? TimesPastDueOver90Days { get; set; }
        public int? CurrYtdInterest { get; set; }
        public int? FairValuePremiumDiscount { get; set; }
        public int? GovernmentGuaranteed { get; set; }
        public int? GuaranteedPercent { get; set; }
        public int? GuaranteedAmount { get; set; }
        public int? CallReportCode { get; set; }
        public int? CollateralCode { get; set; }
        public int? CollateralCodeDesc { get; set; }
        public int? ProductCode { get; set; }
        public int? ProductDescription { get; set; }
        public int? AlllSegmentation { get; set; }
        public int? SecondarySegmentation { get; set; }
        public int? MsaCode { get; set; }
        public int? MsaCodeDesc { get; set; }
        public int? NaicsCode { get; set; }
        public int? NaicsDescription { get; set; }
        public int? Zip { get; set; }
        public int? AccountingGroup { get; set; }
        public int? AccountingGroupDesc { get; set; }
        public int? FloorRate { get; set; }
        public int? CeilingRate { get; set; }
        public int? TimesRenewedExtended { get; set; }
        public int? BorrowersAddress { get; set; }
        public int? City { get; set; }
        public int? State { get; set; }
        public int? CollateralAddress { get; set; }
        public int? ClassCode { get; set; }
        public int? TotalAmountPastDue { get; set; }
        public int? Portfolio { get; set; }
        public int? GlSegment { get; set; }
        public int? PurposeCode { get; set; }
        public int? PurposeCodeDesc { get; set; }
        public int? Participations { get; set; }
        public int? FasType { get; set; }
        public int? RegPaymentPIAmount { get; set; }
        public int? RegularPaymentFrequency { get; set; }
        public int? DateLastPayment { get; set; }
        public int? AmountLastPayment { get; set; }
        public int? LoanRatingCode1 { get; set; }
        public int? LoanRatingCode1FullDesc { get; set; }
        public int? PaymentType { get; set; }
        public int? NetUnearnedDeferredFees { get; set; }
        public int? Interest { get; set; }
        public int? NetNonAccrualPaidInterest { get; set; }
        public int? MiscellaneousCode { get; set; }
        public int? PurchasedLoans { get; set; }
    }
}
