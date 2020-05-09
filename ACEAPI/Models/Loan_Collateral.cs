using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class Loan_Collateral
    {
        public int CollateralId { get; set; }
        public int LoanId { get; set; }
        public string CollateralCode { get; set; }
        public bool? PurchaseMoney { get; set; }
        public decimal? CostSalesPrice { get; set; }
        public decimal? AppraisedValue { get; set; }
        public decimal? AdditionalCollateralValue { get; set; }
        public decimal? ActualValue { get; set; }
        public decimal? ActualLtv { get; set; }
        public string AppraisalGuideline { get; set; }
        public bool? CrossCollateralized { get; set; }
        public string CcloanNumbers { get; set; }
        public string LegalDescription { get; set; }
        public bool? BorrowerOwnsCollateral { get; set; }
        public string Owners { get; set; }
        public string Cdnumber { get; set; }
        public decimal? Cdrate { get; set; }
        public decimal? CdholdAmount { get; set; }
        public bool? ReleaseHold { get; set; }
        public string FromLoan { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCountry { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyPostalCode { get; set; }
        public bool? OwnerOccupied { get; set; }
        public bool? SubjectToReleasePrice { get; set; }
        public decimal? ReleasePrice { get; set; }
        public bool? FloodZone { get; set; }
        public decimal? OutstandingLienAmount { get; set; }
        public string OutstandingLienLoanNumber { get; set; }
        public decimal? EstimatedValue { get; set; }
        public decimal? AppraisedAsIs { get; set; }
        public decimal? AppraisedAsCompleted { get; set; }
        public decimal? AppraisedAsStabilized { get; set; }
        public string SourceOfValuation { get; set; }
        public DateTime? DateOfValuation { get; set; }
        public string AppraisalDeliveryMethod { get; set; }
        public DateTime? AppraisalDeliveryDate { get; set; }
        public decimal? EstimatedLtv { get; set; }
        public string AbundanceOfCaution { get; set; }
        public string PolicyInstitution { get; set; }
        public string PolicyNumber { get; set; }
        public string CollateralComments { get; set; }
        public bool? IsPrimary { get; set; }
        public string MiscPropertyInformation { get; set; }
        public string LienPosition { get; set; }
        public decimal? PolicyAmount { get; set; }
        public string PolicyOwner { get; set; }
        public decimal? PolicyAssignmentAmount { get; set; }
    }
}
