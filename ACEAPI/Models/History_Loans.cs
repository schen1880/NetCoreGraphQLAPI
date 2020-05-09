using System;
using System.Collections.Generic;

namespace ACEAPI.Models
{
    public partial class History_Loans
    {
        public long HistoryId { get; set; }
        public int LoanId { get; set; }
        public int? ProspectLoanId { get; set; }
        public string LoanNumber { get; set; }
        public string LoanNumberOrdinal { get; set; }
        public string DealName { get; set; }
        public string LoanType { get; set; }
        public string LoanRequestType { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? ApprovedLoanAmount { get; set; }
        public string CurrentWorkflowStageGate { get; set; }
        public string CurrentWorkflowActivity { get; set; }
        public DateTime? NoteDate { get; set; }
        public string LendingOfficer { get; set; }
        public string SecondaryLendingOfficer { get; set; }
        public string Branch { get; set; }
        public string PortfolioNumber { get; set; }
        public decimal? AnticipatedFundingAmount { get; set; }
        public DateTime? AnticipatedFundingDate { get; set; }
        public decimal? BalanceIncrease { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? RequestedCloseDate { get; set; }
        public short? RiskGrade { get; set; }
        public string EmployeeCode { get; set; }
        public bool? RegW { get; set; }
        public decimal? AnnualGrossRevenueIncome { get; set; }
        public string RevenueCode { get; set; }
        public string Naicscode { get; set; }
        public string ClassCode { get; set; }
        public string PurposeCode { get; set; }
        public string ProductCode { get; set; }
        public string LoanPurposeSummary { get; set; }
        public string ParticipationLeadBank { get; set; }
        public decimal? ParticipationAmountPurchased { get; set; }
        public decimal? ParticipationPercentPurchased { get; set; }
        public DateTime? CoreDatePulled { get; set; }
        public decimal? RdcdebtAmount { get; set; }
        public bool? SendToUnderwriting { get; set; }
        public DateTime? UwrequestedDate { get; set; }
        public string AnalystName { get; set; }
        public string PreparedInternalExternal { get; set; }
        public string PreparedDesc { get; set; }
        public bool? IsRenewal { get; set; }
        public bool? IsMasterGuidanceline { get; set; }
        public bool? IsSubGuidanceline { get; set; }
        public int? ParentLoanId { get; set; }
        public DateTime? DatePaidOff { get; set; }
        public string LastSavedBy { get; set; }
        public DateTime? LastSavedTimestamp { get; set; }
        public int? ProcessId { get; set; }
        public string ExecutiveSummary { get; set; }
        public bool? IsTdr { get; set; }
        public string ParticipationContactName { get; set; }
        public string ParticipationContactPhone { get; set; }
        public string ParticipationContactEmail { get; set; }
        public string RiskGradeChangeJustification { get; set; }
        public byte? Probability { get; set; }
        public decimal? LoanRoa { get; set; }
        public decimal? LoanRoe { get; set; }
        public decimal? RelationshipRoa { get; set; }
        public decimal? RelationshipRoe { get; set; }
    }
}
