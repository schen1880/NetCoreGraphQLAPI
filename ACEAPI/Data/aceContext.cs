using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ACEAPI.Models;

namespace ACEAPI.Data
{
    public partial class aceContext : DbContext
    {
        public aceContext()
        {
        }

        public aceContext(DbContextOptions<aceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tms_ACHInformation> Achinformation { get; set; }
        public virtual DbSet<Loan_ActionsComments> ActionsComments { get; set; }
        public virtual DbSet<Loan_AdverseAction> AdverseAction { get; set; }
        public virtual DbSet<Loan_AdverseActionReasons> AdverseActionReasons { get; set; }
        public virtual DbSet<Dbo_AvailableLoanNumbers> AvailableLoanNumbers { get; set; }
        public virtual DbSet<Dbo_BackupData121919> BackupData121919 { get; set; }
        public virtual DbSet<Dbo_BranchCodes> BranchCodes { get; set; }
        public virtual DbSet<Cip_CIP> Cip { get; set; }
        public virtual DbSet<Dbo_ClassCodes> ClassCodes { get; set; }
        public virtual DbSet<Tms_ClientInformation> ClientInformation { get; set; }
        public virtual DbSet<History_Collateral> Collateral { get; set; }
        public virtual DbSet<Loan_Collateral> Collateral1 { get; set; }
        public virtual DbSet<Dbo_CollateralCodes> CollateralCodes { get; set; }
        public virtual DbSet<Daily_CollateralExtract> CollateralExtract { get; set; }
        public virtual DbSet<Prospect_Comments> Comments { get; set; }
        public virtual DbSet<Prospect_ContactMethods> ContactMethods { get; set; }
        public virtual DbSet<Currentdata122319> Currentdata122319 { get; set; }
        public virtual DbSet<Currentdata1223192> Currentdata1223192 { get; set; }
        public virtual DbSet<Conversion_CustomerExperience> CustomerExperience { get; set; }
        public virtual DbSet<Conversion_CustomerExperienceNotes> CustomerExperienceNotes { get; set; }
        public virtual DbSet<Daily_CustomerExtract> CustomerExtract { get; set; }
        public virtual DbSet<Loan_DebtTypes> DebtTypes { get; set; }
        public virtual DbSet<History_Debts> Debts { get; set; }
        public virtual DbSet<Loan_Debts> Debts1 { get; set; }
        public virtual DbSet<Tms_Debts> Debts2 { get; set; }
        public virtual DbSet<Document_DeletedDocumentsLogging> DeletedDocumentsLogging { get; set; }
        public virtual DbSet<History_Deposits> Deposits { get; set; }
        public virtual DbSet<Loan_Deposits> Deposits1 { get; set; }
        public virtual DbSet<Tms_Deposits> Deposits2 { get; set; }
        public virtual DbSet<Loan_DisbursalTypes> DisbursalTypes { get; set; }
        public virtual DbSet<History_Disbursals> Disbursals { get; set; }
        public virtual DbSet<Loan_Disbursals> Disbursals1 { get; set; }
        public virtual DbSet<Loan_Documents> Documents { get; set; }
        public virtual DbSet<Tms_Documents> Documents1 { get; set; }
        public virtual DbSet<Dbo_EmployeeCodes> EmployeeCodes { get; set; }
        public virtual DbSet<Dbo_EntityTypes> EntityTypes { get; set; }
        public virtual DbSet<Dbo_EscrowCodes> EscrowCodes { get; set; }
        public virtual DbSet<Loan_ExceptionTypes> ExceptionTypes { get; set; }
        public virtual DbSet<Loan_FeeTypes> FeeTypes { get; set; }
        public virtual DbSet<History_Fees> Fees { get; set; }
        public virtual DbSet<Loan_Fees> Fees1 { get; set; }
        public virtual DbSet<Dbo_FrequencyCodes> FrequencyCodes { get; set; }
        public virtual DbSet<History_FTBorrowingBase> FtborrowingBase { get; set; }
        public virtual DbSet<Loan_FTBorrowingBase> FtborrowingBase1 { get; set; }
        public virtual DbSet<History_FTBorrowingBaseIneligibles> FtborrowingBaseIneligibles { get; set; }
        public virtual DbSet<Loan_FTBorrowingBaseIneligibles> FtborrowingBaseIneligibles1 { get; set; }
        public virtual DbSet<Loan_FTDocuments> Ftdocuments { get; set; }
        public virtual DbSet<History_FTFinancialStatements> FtfinancialStatements { get; set; }
        public virtual DbSet<Loan_FTFinancialStatements> FtfinancialStatements1 { get; set; }
        public virtual DbSet<History_FTQuantitativeCovenants> FtquantitativeCovenants { get; set; }
        public virtual DbSet<Loan_FTQuantitativeCovenants> FtquantitativeCovenants1 { get; set; }
        public virtual DbSet<Conversion_FunctionalAreas> FunctionalAreas { get; set; }
        public virtual DbSet<Conversion_FunctionalSegments> FunctionalSegments { get; set; }
        public virtual DbSet<History_HMDA> Hmda { get; set; }
        public virtual DbSet<Loan_HMDA> Hmda1 { get; set; }
        public virtual DbSet<Dbo_HMDACodes> Hmdacodes { get; set; }
        public virtual DbSet<History_HVCRE> Hvcre { get; set; }
        public virtual DbSet<Loan_HVCRE> Hvcre1 { get; set; }
        public virtual DbSet<Cip_IdentificationTypes> IdentificationTypes { get; set; }
        public virtual DbSet<Dbo_LendingOfficerAuthority> LendingOfficerAuthority { get; set; }
        public virtual DbSet<Dbo_LendingOfficers> LendingOfficers { get; set; }
        public virtual DbSet<Dbo_LendingOfficersAssistants> LendingOfficersAssistants { get; set; }
        public virtual DbSet<Daily_LoanCustomer_XREFExtract> LoanCustomerXrefextract { get; set; }
        public virtual DbSet<Daily_LoanExtract> LoanExtract { get; set; }
        public virtual DbSet<Prospect_LoanTypes> LoanTypes { get; set; }
        public virtual DbSet<History_Loans> Loans { get; set; }
        public virtual DbSet<Loan_Loans> Loans1 { get; set; }
        public virtual DbSet<Prospect_Loans> Loans2 { get; set; }
        public virtual DbSet<Document_MultipleLoans> MultipleLoans { get; set; }
        public virtual DbSet<Document_MultipleTaxIds> MultipleTaxIds { get; set; }
        public virtual DbSet<Dbo_NAICSCodes> Naicscodes { get; set; }
        public virtual DbSet<History_NotesComments> NotesComments { get; set; }
        public virtual DbSet<Loan_NotesComments> NotesComments1 { get; set; }
        public virtual DbSet<Tms_NotesComments> NotesComments2 { get; set; }
        public virtual DbSet<History_Obligors> Obligors { get; set; }
        public virtual DbSet<Loan_Obligors> Obligors1 { get; set; }
        public virtual DbSet<Tms_OnboardingACHInformation> OnboardingAchinformation { get; set; }
        public virtual DbSet<Tms_OnboardingClientInformation> OnboardingClientInformation { get; set; }
        public virtual DbSet<Tms_OnboardingDebts> OnboardingDebts { get; set; }
        public virtual DbSet<Tms_OnboardingDeposits> OnboardingDeposits { get; set; }
        public virtual DbSet<Tms_OnboardingRDCInformation> OnboardingRdcinformation { get; set; }
        public virtual DbSet<History_PaymentStream> PaymentStream { get; set; }
        public virtual DbSet<Loan_PaymentStream> PaymentStream1 { get; set; }
        public virtual DbSet<History_PolicyExceptions> PolicyExceptions { get; set; }
        public virtual DbSet<Loan_PolicyExceptions> PolicyExceptions1 { get; set; }
        public virtual DbSet<Prospect_PotentialDeposits> PotentialDeposits { get; set; }
        public virtual DbSet<Dbo_PreparedByLookup> PreparedByLookup { get; set; }
        public virtual DbSet<Loan_PrepaymentPenalties> PrepaymentPenalties { get; set; }
        public virtual DbSet<Dbo_ProductCodes> ProductCodes { get; set; }
        public virtual DbSet<Prospect_Prospects> Prospects { get; set; }
        public virtual DbSet<Dbo_PurposeCodes> PurposeCodes { get; set; }
        public virtual DbSet<Dbo_RateCodes> RateCodes { get; set; }
        public virtual DbSet<History_Rates> Rates { get; set; }
        public virtual DbSet<Loan_Rates> Rates1 { get; set; }
        public virtual DbSet<Tms_RDCInformation> Rdcinformation { get; set; }
        public virtual DbSet<Prospect_RelationshipEnhancementOpportunities> RelationshipEnhancementOpportunities { get; set; }
        public virtual DbSet<Prospect_RelationshipEnhancementOpportunitiesNotes> RelationshipEnhancementOpportunitiesNotes { get; set; }
        public virtual DbSet<Dbo_RelationshipManagers> RelationshipManagers { get; set; }
        public virtual DbSet<History_Repayment> Repayment { get; set; }
        public virtual DbSet<Loan_Repayment> Repayment1 { get; set; }
        public virtual DbSet<Loan_RequestTypes> RequestTypes { get; set; }
        public virtual DbSet<Document_RequiredDocumentsByCollateralCode> RequiredDocumentsByCollateralCode { get; set; }
        public virtual DbSet<Document_RequiredDocumentsByEntityType> RequiredDocumentsByEntityType { get; set; }
        public virtual DbSet<Document_RequiredDocumentsByPurposeCode> RequiredDocumentsByPurposeCode { get; set; }
        public virtual DbSet<Document_RequiredDocumentsByStageGate> RequiredDocumentsByStageGate { get; set; }
        public virtual DbSet<Dbo_RiskCodes> RiskCodes { get; set; }
        public virtual DbSet<Loan_RiskRatingChanges> RiskRatingChanges { get; set; }
        public virtual DbSet<Dbo_StateCodes> StateCodes { get; set; }
        public virtual DbSet<History_StrengthWeakness> StrengthWeakness { get; set; }
        public virtual DbSet<Loan_StrengthWeakness> StrengthWeakness1 { get; set; }
        public virtual DbSet<History_SubGuidanceLine> SubGuidanceLine { get; set; }
        public virtual DbSet<Loan_SubGuidanceLine> SubGuidanceLine1 { get; set; }
        public virtual DbSet<History_SubjectTo> SubjectTo { get; set; }
        public virtual DbSet<Loan_SubjectTo> SubjectTo1 { get; set; }
        public virtual DbSet<Daily_TaxID_To_RespCode> TaxIdToRespCode { get; set; }
        public virtual DbSet<Document_Taxonomy> Taxonomy { get; set; }
        public virtual DbSet<Daily_Tm_Client> TmClient { get; set; }
        public virtual DbSet<History_TmsACHInformation> TmsAchinformation { get; set; }
        public virtual DbSet<History_TmsClientInformation> TmsClientInformation { get; set; }
        public virtual DbSet<History_TmsDebts> TmsDebts { get; set; }
        public virtual DbSet<History_TmsDeposits> TmsDeposits { get; set; }
        public virtual DbSet<History_TmsRDCInformation> TmsRdcinformation { get; set; }
        public virtual DbSet<Document_UploadedDocuments> UploadedDocuments { get; set; }
        public virtual DbSet<VwAchrdcportfolio> VwAchrdcportfolio { get; set; }
        public virtual DbSet<VwAchrdcrenewals> VwAchrdcrenewals { get; set; }
        public virtual DbSet<VwCustomerCreditDocuments> VwCustomerCreditDocuments { get; set; }
        public virtual DbSet<VwDocumentIdentifiers> VwDocumentIdentifiers { get; set; }
        public virtual DbSet<VwKlcreditDocumentIdentifier> VwKlcreditDocumentIdentifier { get; set; }
        public virtual DbSet<VwKldocumentIdentifier> VwKldocumentIdentifier { get; set; }
        public virtual DbSet<VwLoanCollateralDocuments> VwLoanCollateralDocuments { get; set; }
        public virtual DbSet<VwOreoextract> VwOreoextract { get; set; }
        public virtual DbSet<VwProspectsObligors> VwProspectsObligors { get; set; }
        public virtual DbSet<VwTrackingDocuments> VwTrackingDocuments { get; set; }
        public virtual DbSet<Dbo_WorkflowConstants> WorkflowConstants { get; set; }
        public virtual DbSet<Loan_WorkflowStages> WorkflowStages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tms_ACHInformation>(entity =>
            {
                entity.HasKey(e => e.Achid);

                entity.ToTable("ACHInformation", "tms");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("idx_ClientNumber");

                entity.Property(e => e.Achid).HasColumnName("ACHId");

                entity.Property(e => e.AchcompanyId)
                    .HasColumnName("ACHCompanyID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateBalance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.DailyAchcredits)
                    .HasColumnName("DailyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DailyAchdebits)
                    .HasColumnName("DailyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DemandBalance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.MonthlyAchcredits)
                    .HasColumnName("MonthlyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MonthlyAchdebits)
                    .HasColumnName("MonthlyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .IsRequired()
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TIN')");

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Loan_ActionsComments>(entity =>
            {
                entity.HasKey(e => e.ActionCommentId);

                entity.ToTable("ActionsComments", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.ActionCommentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedAction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_AdverseAction>(entity =>
            {
                entity.HasKey(e => e.AdverseActionId);

                entity.ToTable("AdverseAction", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.Aadate)
                    .HasColumnName("AADate")
                    .HasColumnType("date");

                entity.Property(e => e.Aadetails)
                    .HasColumnName("AADetails")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Aareason)
                    .HasColumnName("AAReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_AdverseActionReasons>(entity =>
            {
                entity.HasKey(e => e.AareasonId);

                entity.ToTable("AdverseActionReasons", "loan");

                entity.Property(e => e.AareasonId)
                    .HasColumnName("AAReasonId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aareason)
                    .IsRequired()
                    .HasColumnName("AAReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_AvailableLoanNumbers>(entity =>
            {
                entity.HasKey(e => e.LoanNumber);

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsAssigned).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dbo_BackupData121919>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backupData121919");

                entity.Property(e => e.DocumentClassification).HasMaxLength(50);

                entity.Property(e => e.DocumentIdentifier).HasMaxLength(50);

                entity.Property(e => e.DocumentName).HasMaxLength(50);

                entity.Property(e => e.LastSavedBy).HasMaxLength(50);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dbo_BranchCodes>(entity =>
            {
                entity.HasKey(e => e.BranchCode);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BranchDisplay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cip_CIP>(entity =>
            {
                entity.HasKey(e => e.Cipid);

                entity.ToTable("CIP", "cip");

                entity.HasIndex(e => e.TaxIdssn)
                    .HasName("idx_taxidssn");

                entity.Property(e => e.Cipid).HasColumnName("CIPID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.IdexpirationDate)
                    .HasColumnName("IDExpirationDate")
                    .HasColumnType("date");

                entity.Property(e => e.IdissueDate)
                    .HasColumnName("IDIssueDate")
                    .HasColumnType("date");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdstateCountry)
                    .HasColumnName("IDStateCountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idtype)
                    .HasColumnName("IDType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.MailingAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryIdexpirationDate)
                    .HasColumnName("SecondaryIDExpirationDate")
                    .HasColumnType("date");

                entity.Property(e => e.SecondaryIdissueDate)
                    .HasColumnName("SecondaryIDIssueDate")
                    .HasColumnType("date");

                entity.Property(e => e.SecondaryIdnumber)
                    .HasColumnName("SecondaryIDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryIdstateCountry)
                    .HasColumnName("SecondaryIDStateCountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryIdtype)
                    .HasColumnName("SecondaryIDType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .IsRequired()
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssntype)
                    .HasColumnName("TaxIDSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SSN')");
            });

            modelBuilder.Entity<Dbo_ClassCodes>(entity =>
            {
                entity.HasKey(e => e.ClassCode);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClassDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fdiccode)
                    .HasColumnName("FDICCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_ClientInformation>(entity =>
            {
                entity.HasKey(e => e.ClientNumber);

                entity.ToTable("ClientInformation", "tms");

                entity.Property(e => e.ClientNumber).ValueGeneratedNever();

                entity.Property(e => e.Achstatus)
                    .HasColumnName("ACHStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rdcstatus)
                    .HasColumnName("RDCStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<History_Collateral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Collateral", "history");

                entity.Property(e => e.AbundanceOfCaution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActualLtv)
                    .HasColumnName("ActualLTV")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ActualValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AdditionalCollateralValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisalDeliveryDate).HasColumnType("date");

                entity.Property(e => e.AppraisalDeliveryMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisalGuideline)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisedAsCompleted).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedAsIs).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedAsStabilized).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CcloanNumbers)
                    .HasColumnName("CCLoanNumbers")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CdholdAmount)
                    .HasColumnName("CDHoldAmount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cdnumber)
                    .HasColumnName("CDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cdrate)
                    .HasColumnName("CDRate")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.CollateralCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CostSalesPrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DateOfValuation).HasColumnType("date");

                entity.Property(e => e.EstimatedLtv)
                    .HasColumnName("EstimatedLTV")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EstimatedValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FromLoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LegalDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LienPosition)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiscPropertyInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingLienAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutstandingLienLoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Owners)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PolicyAssignmentAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PolicyInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasePrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SourceOfValuation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Collateral>(entity =>
            {
                entity.HasKey(e => e.CollateralId);

                entity.ToTable("Collateral", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.AbundanceOfCaution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActualLtv)
                    .HasColumnName("ActualLTV")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ActualValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AdditionalCollateralValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisalDeliveryDate).HasColumnType("date");

                entity.Property(e => e.AppraisalDeliveryMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisalGuideline)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisedAsCompleted).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedAsIs).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedAsStabilized).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AppraisedValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CcloanNumbers)
                    .HasColumnName("CCLoanNumbers")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CdholdAmount)
                    .HasColumnName("CDHoldAmount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cdnumber)
                    .HasColumnName("CDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cdrate)
                    .HasColumnName("CDRate")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.CollateralCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CostSalesPrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DateOfValuation).HasColumnType("date");

                entity.Property(e => e.EstimatedLtv)
                    .HasColumnName("EstimatedLTV")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EstimatedValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FromLoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LegalDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LienPosition)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiscPropertyInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingLienAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutstandingLienLoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Owners)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PolicyAssignmentAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PolicyInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasePrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SourceOfValuation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_CollateralCodes>(entity =>
            {
                entity.HasKey(e => e.CollateralCode);

                entity.Property(e => e.CollateralCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClassification)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daily_CollateralExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CollateralExtract", "daily");

                entity.HasIndex(e => e.CollateralId)
                    .HasName("idx_Collateral_ID");

                entity.Property(e => e.AppraisalValue)
                    .HasColumnName("Appraisal_Value")
                    .HasColumnType("money");

                entity.Property(e => e.CollateralCode)
                    .HasColumnName("Collateral_Code")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CollateralCodeDesc)
                    .HasColumnName("Collateral_Code_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralId)
                    .HasColumnName("Collateral_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralIdentifier)
                    .HasColumnName("Collateral_Identifier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralValue)
                    .HasColumnName("Collateral_Value")
                    .HasColumnType("money");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAppraised)
                    .HasColumnName("Date_Appraised")
                    .HasColumnType("money");

                entity.Property(e => e.Description1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameId)
                    .HasColumnName("Name_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoteNumber)
                    .HasColumnName("Note_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrigCollateralValue)
                    .HasColumnName("Orig_Collateral_Value")
                    .HasColumnType("money");

                entity.Property(e => e.OwnerOccupiedCodeDesc)
                    .HasColumnName("Owner_Occupied_Code_Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("Product_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect_Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Comments", "prospect");

                entity.Property(e => e.CallDate).HasColumnType("date");

                entity.Property(e => e.CommentDetails)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.CommentUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect_ContactMethods>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ContactMethods", "prospect");

                entity.Property(e => e.ContactMethod)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currentdata122319>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("currentdata-12-23-19");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currentdata1223192>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("currentdata-12-23-19_2");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conversion_CustomerExperience>(entity =>
            {
                entity.HasKey(e => e.Cxid);

                entity.ToTable("CustomerExperience", "conversion");

                entity.Property(e => e.Cxid).HasColumnName("CXId");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNotes).IsUnicode(false);

                entity.Property(e => e.Approvals)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Criticality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FunctionalArea)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalSegment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResolutionNotes).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conversion_CustomerExperienceNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("CustomerExperienceNotes", "conversion");

                entity.Property(e => e.Cxid).HasColumnName("CXId");

                entity.Property(e => e.NoteComment).IsUnicode(false);

                entity.Property(e => e.NoteTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NoteUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daily_CustomerExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerExtract", "daily");

                entity.HasIndex(e => e.NameId)
                    .HasName("idx_Name_ID");

                entity.Property(e => e.AccountAddress)
                    .HasColumnName("Account_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountAddress2)
                    .HasColumnName("Account_Address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCity)
                    .HasColumnName("Account_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountState)
                    .HasColumnName("Account_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccountZip)
                    .HasColumnName("Account_Zip")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountingBranch)
                    .HasColumnName("Accounting_Branch")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AccountingBranchDescription)
                    .HasColumnName("Accounting_Branch_Description")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualGrossRevenue)
                    .HasColumnName("Annual_Gross_Revenue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPhone)
                    .HasColumnName("Business_Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CellularPhone)
                    .HasColumnName("Cellular_Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasColumnName("Customer_Type")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormattedTaxId)
                    .HasColumnName("Formatted_Tax_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("Home_Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NaicsCode)
                    .HasColumnName("NAICS_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NaicsDescription)
                    .HasColumnName("NAICS_Description")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.NameId)
                    .HasColumnName("Name_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Portfolio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryName)
                    .HasColumnName("Primary_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCodeFullDesc)
                    .HasColumnName("Responsibility_Code_Full_Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortFirstName)
                    .HasColumnName("Short_First_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShortLastName)
                    .HasColumnName("Short_Last_Name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdCodeDescription)
                    .HasColumnName("Tax_ID_Code_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdDescription)
                    .HasColumnName("Tax_ID_Description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_DebtTypes>(entity =>
            {
                entity.HasKey(e => e.DebtTypeCode);

                entity.ToTable("DebtTypes", "loan");

                entity.Property(e => e.DebtTypeCode).ValueGeneratedNever();

                entity.Property(e => e.DebtTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Debts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Debts", "history");

                entity.Property(e => e.DirectCommittedAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NewRequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OfficerLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedCommittedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Loan_Debts>(entity =>
            {
                entity.HasKey(e => e.DebtId);

                entity.ToTable("Debts", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.DirectCommittedAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NewRequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OfficerLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedCommittedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Tms_Debts>(entity =>
            {
                entity.HasKey(e => e.DebtId);

                entity.ToTable("Debts", "tms");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("idx_ClientNumber");

                entity.Property(e => e.DirectCommittedAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NewRequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OfficerLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedCommittedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Document_DeletedDocumentsLogging>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("DeletedDocumentsLogging", "document");

                entity.Property(e => e.DeletedByUserName).IsUnicode(false);

                entity.Property(e => e.DeletedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.DocumentIdentifier).IsUnicode(false);

                entity.Property(e => e.DocumentName).IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("DocumentURL")
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumber).IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .HasColumnName("TaxIdSSN")
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDocumentId).IsUnicode(false);
            });

            modelBuilder.Entity<History_Deposits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Deposits", "history");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Loan_Deposits>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("Deposits", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Tms_Deposits>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("Deposits", "tms");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("idx_ClientNumber");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Loan_DisbursalTypes>(entity =>
            {
                entity.HasKey(e => e.DisbursalTypeId);

                entity.ToTable("DisbursalTypes", "loan");

                entity.Property(e => e.DisbursalTypeId).ValueGeneratedNever();

                entity.Property(e => e.DisbursalType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Disbursals>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Disbursals", "history");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DisbursalComments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalDate).HasColumnType("date");

                entity.Property(e => e.DisbursalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Disbursals>(entity =>
            {
                entity.HasKey(e => e.DisbursalId);

                entity.ToTable("Disbursals", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DisbursalComments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalDate).HasColumnType("date");

                entity.Property(e => e.DisbursalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisbursalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("Documents", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => new { e.DocumentName, e.TaxIdssn })
                    .HasName("IX_Documents_TaxIDSSN");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("Documents", "tms");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("idx_ClientNumber");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_EmployeeCodes>(entity =>
            {
                entity.HasKey(e => e.EmployeeCode);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_EntityTypes>(entity =>
            {
                entity.HasKey(e => e.EntityType);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityTypeDisplay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_EscrowCodes>(entity =>
            {
                entity.HasKey(e => e.EscrowCode);

                entity.Property(e => e.EscrowCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EscrowDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_ExceptionTypes>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("ExceptionTypes", "loan");

                entity.Property(e => e.ExceptionId).ValueGeneratedNever();

                entity.Property(e => e.ExceptionType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_FeeTypes>(entity =>
            {
                entity.HasKey(e => e.FeeTypeCode);

                entity.ToTable("FeeTypes", "loan");

                entity.Property(e => e.FeeTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FeeTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Fees>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fees", "history");

                entity.Property(e => e.AmountBankPaid).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AmountCash).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AmountFinanced).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FeeCollection)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FeeTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FixedOrPercent)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Fees>(entity =>
            {
                entity.HasKey(e => e.FeeId);

                entity.ToTable("Fees", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.AmountBankPaid).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AmountCash).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AmountFinanced).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FeeCollection)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FeeTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FixedOrPercent)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_FrequencyCodes>(entity =>
            {
                entity.HasKey(e => e.FrequencyCode);

                entity.Property(e => e.FrequencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrequencyDisplay)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_FTBorrowingBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTBorrowingBase", "history");

                entity.Property(e => e.AdvRates).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Bbcomments)
                    .HasColumnName("BBComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ftbbid).HasColumnName("FTBBId");

                entity.Property(e => e.Ineligible)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaxConcentration).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<Loan_FTBorrowingBase>(entity =>
            {
                entity.HasKey(e => e.Ftbbid);

                entity.ToTable("FTBorrowingBase", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.ObligorId)
                    .HasName("idx_obligorid");

                entity.Property(e => e.Ftbbid).HasColumnName("FTBBId");

                entity.Property(e => e.AdvRates).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Bbcomments)
                    .HasColumnName("BBComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ineligible)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaxConcentration).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<History_FTBorrowingBaseIneligibles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTBorrowingBaseIneligibles", "history");

                entity.Property(e => e.Bbicomments)
                    .HasColumnName("BBIComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ftbbiid).HasColumnName("FTBBIId");
            });

            modelBuilder.Entity<Loan_FTBorrowingBaseIneligibles>(entity =>
            {
                entity.HasKey(e => e.Ftbbiid);

                entity.ToTable("FTBorrowingBaseIneligibles", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.ObligorId)
                    .HasName("idx_obligorid");

                entity.Property(e => e.Ftbbiid).HasColumnName("FTBBIId");

                entity.Property(e => e.Bbicomments)
                    .HasColumnName("BBIComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_FTDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTDocuments", "loan");

                entity.Property(e => e.BorrowingBase).HasDefaultValueSql("((0))");

                entity.Property(e => e.BorrowingBaseIneligibles).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialStatements).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantitativeCovenants).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<History_FTFinancialStatements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTFinancialStatements", "history");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fscomments)
                    .HasColumnName("FSComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ftfsid).HasColumnName("FTFSId");

                entity.Property(e => e.GracePeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_FTFinancialStatements>(entity =>
            {
                entity.HasKey(e => e.Ftfsid);

                entity.ToTable("FTFinancialStatements", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.ObligorId)
                    .HasName("idx_obligorid");

                entity.Property(e => e.Ftfsid).HasColumnName("FTFSId");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fscomments)
                    .HasColumnName("FSComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GracePeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_FTQuantitativeCovenants>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTQuantitativeCovenants", "history");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ftqcid).HasColumnName("FTQCId");

                entity.Property(e => e.Qccomments)
                    .HasColumnName("QCComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RatioActual).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.RatioRequired).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Sqannual)
                    .HasColumnName("SQAnnual")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqasOfDate)
                    .HasColumnName("SQAsOfDate")
                    .HasColumnType("date");

                entity.Property(e => e.Sqfrequency)
                    .HasColumnName("SQFrequency")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sqinterim)
                    .HasColumnName("SQInterim")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_FTQuantitativeCovenants>(entity =>
            {
                entity.HasKey(e => e.Ftqcid);

                entity.ToTable("FTQuantitativeCovenants", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.ObligorId)
                    .HasName("idx_obligorid");

                entity.Property(e => e.Ftqcid).HasColumnName("FTQCId");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Qccomments)
                    .HasColumnName("QCComments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RatioActual).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.RatioRequired).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Sqannual)
                    .HasColumnName("SQAnnual")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqasOfDate)
                    .HasColumnName("SQAsOfDate")
                    .HasColumnType("date");

                entity.Property(e => e.Sqfrequency)
                    .HasColumnName("SQFrequency")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sqinterim)
                    .HasColumnName("SQInterim")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conversion_FunctionalAreas>(entity =>
            {
                entity.HasKey(e => e.FunctionalArea);

                entity.ToTable("FunctionalAreas", "conversion");

                entity.Property(e => e.FunctionalArea)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conversion_FunctionalSegments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FunctionalSegments", "conversion");

                entity.Property(e => e.FunctionalArea)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalSegment)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_HMDA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HMDA", "history");

                entity.Property(e => e.Hmdacode)
                    .HasColumnName("HMDACode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Hmdaid).HasColumnName("HMDAId");

                entity.Property(e => e.IsHmda).HasColumnName("isHMDA");
            });

            modelBuilder.Entity<Loan_HMDA>(entity =>
            {
                entity.HasKey(e => e.Hmdaid);

                entity.ToTable("HMDA", "loan");

                entity.Property(e => e.Hmdaid).HasColumnName("HMDAId");

                entity.Property(e => e.Hmdacode)
                    .HasColumnName("HMDACode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsHmda).HasColumnName("isHMDA");
            });

            modelBuilder.Entity<Dbo_HMDACodes>(entity =>
            {
                entity.HasKey(e => e.Hmdacode);

                entity.ToTable("HMDACodes");

                entity.Property(e => e.Hmdacode)
                    .HasColumnName("HMDACode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hmdadescription)
                    .IsRequired()
                    .HasColumnName("HMDADescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_HVCRE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HVCRE", "history");

                entity.Property(e => e.Hvcreid).HasColumnName("HVCREId");

                entity.Property(e => e.IsHvcre).HasColumnName("isHVCRE");
            });

            modelBuilder.Entity<Loan_HVCRE>(entity =>
            {
                entity.HasKey(e => e.Hvcreid);

                entity.ToTable("HVCRE", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.Hvcreid).HasColumnName("HVCREId");

                entity.Property(e => e.IsHvcre).HasColumnName("isHVCRE");
            });

            modelBuilder.Entity<Cip_IdentificationTypes>(entity =>
            {
                entity.HasKey(e => e.Idtype);

                entity.ToTable("IdentificationTypes", "cip");

                entity.Property(e => e.Idtype)
                    .HasColumnName("IDType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iddisplay)
                    .IsRequired()
                    .HasColumnName("IDDisplay")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_LendingOfficerAuthority>(entity =>
            {
                entity.HasKey(e => e.AuthorityId);

                entity.Property(e => e.AuthorityAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_LendingOfficers>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityLevel).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAuthority).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Dbo_LendingOfficersAssistants>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LendingAssistantUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LendingOfficerUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daily_LoanCustomer_XREFExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoanCustomer_XREFExtract", "daily");

                entity.HasIndex(e => e.NoteNumber)
                    .HasName("idx_Guarantor_ID");

                entity.Property(e => e.NameId)
                    .HasColumnName("Name_ID")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.NoteNumber)
                    .HasColumnName("Note_Number")
                    .HasColumnType("numeric(20, 0)");
            });

            modelBuilder.Entity<Daily_LoanExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoanExtract", "daily");

                entity.HasIndex(e => e.LoanNumber)
                    .HasName("idx_Loan_Number");

                entity.Property(e => e.AccountingGroup)
                    .HasColumnName("Accounting_Group")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.AccountingGroupDesc)
                    .HasColumnName("Accounting_Group_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlllSegmentation)
                    .HasColumnName("ALLL_Segmentation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AmortizationDays)
                    .HasColumnName("Amortization_Days")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountLastPayment)
                    .HasColumnName("Amount_Last_Payment")
                    .HasColumnType("money");

                entity.Property(e => e.AvailableCredit)
                    .HasColumnName("Available_Credit")
                    .HasColumnType("money");

                entity.Property(e => e.BookBalance)
                    .HasColumnName("Book_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.BorrowersAddress)
                    .HasColumnName("Borrowers_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallReportCode)
                    .HasColumnName("Call_Report_Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CeilingRate)
                    .HasColumnName("Ceiling_Rate")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasColumnName("Class_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralAddress)
                    .HasColumnName("Collateral_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralCode)
                    .HasColumnName("Collateral_Code")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CollateralCodeDesc)
                    .HasColumnName("Collateral_Code_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrYtdInterest)
                    .HasColumnName("Curr_YTD_Interest")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnName("Current_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentInterestMethod)
                    .HasColumnName("Current_Interest_Method")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DateLastPayment)
                    .HasColumnName("Date_Last_Payment")
                    .HasColumnType("date");

                entity.Property(e => e.FairValuePremiumDiscount)
                    .HasColumnName("Fair_Value_PremiumDiscount")
                    .HasColumnType("money");

                entity.Property(e => e.FasType)
                    .HasColumnName("FAS_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FloorRate)
                    .HasColumnName("Floor_Rate")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.GlSegment)
                    .HasColumnName("GL_Segment")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.GovernmentGuaranteed)
                    .HasColumnName("Government_Guaranteed")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GuaranteedAmount)
                    .HasColumnName("Guaranteed_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GuaranteedPercent)
                    .HasColumnName("Guaranteed_Percent")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.Interest).HasColumnType("decimal(12, 5)");

                entity.Property(e => e.InterestRate)
                    .HasColumnName("Interest_Rate")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.InterestRateType)
                    .HasColumnName("Interest_Rate_Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumber)
                    .HasColumnName("Loan_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoanOfficer)
                    .HasColumnName("Loan_Officer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanOfficerCode)
                    .HasColumnName("Loan_Officer_Code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRatingCode1)
                    .HasColumnName("Loan_Rating_Code1")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.LoanRatingCode1FullDesc)
                    .HasColumnName("Loan_Rating_Code1_Full_Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaturityDate)
                    .HasColumnName("Maturity_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MaximumDaysPastDue)
                    .HasColumnName("Maximum_Days_Past_Due")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MiscellaneousCode)
                    .HasColumnName("Miscellaneous_Code")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MsaCode)
                    .HasColumnName("MSA_Code")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MsaCodeDesc)
                    .HasColumnName("MSA_Code_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NaicsCode)
                    .HasColumnName("NAICS_Code")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NaicsDescription)
                    .HasColumnName("NAICS_Description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NameId)
                    .HasColumnName("Name_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetNonAccrualPaidInterest)
                    .HasColumnName("Net_Non_Accrual_Paid_Interest")
                    .HasColumnType("money");

                entity.Property(e => e.NetUnearnedDeferredFees)
                    .HasColumnName("Net_Unearned_Deferred_Fees")
                    .HasColumnType("money");

                entity.Property(e => e.NonAccrual)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NonAccrualDate)
                    .HasColumnName("Non_Accrual_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OriginalBalance)
                    .HasColumnName("Original_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.OriginalNoteDate)
                    .HasColumnName("Original_Note_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Participations)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Portfolio).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("Product_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasedLoans)
                    .HasColumnName("Purchased_Loans")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeCode)
                    .HasColumnName("Purpose_Code")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.PurposeCodeDesc)
                    .HasColumnName("Purpose_Code_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RateAdjuster)
                    .HasColumnName("Rate_Adjuster")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.RateChangePrevIndexRate)
                    .HasColumnName("Rate_Change_Prev_Index_Rate")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.RegPaymentPIAmount)
                    .HasColumnName("Reg_Payment_P_I_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.RegularPaymentFrequency)
                    .HasColumnName("Regular_Payment_Frequency")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingTerm)
                    .HasColumnName("Remaining_Term")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.RenewalBalance)
                    .HasColumnName("Renewal_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.RenewalDate)
                    .HasColumnName("Renewal_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SecondarySegmentation)
                    .HasColumnName("Secondary_Segmentation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCodeFullDesc)
                    .HasColumnName("Status_Code_Full_Desc")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdNumber)
                    .HasColumnName("Tax_Id_Number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tdr)
                    .HasColumnName("TDR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimesPastDue30To59Days)
                    .HasColumnName("Times_Past_Due_30_To_59_Days")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TimesPastDue60To89Days)
                    .HasColumnName("Times_Past_Due_60_To_89_Days")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TimesPastDueOver90Days)
                    .HasColumnName("Times_Past_Due_Over_90_Days")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TimesRenewedExtended)
                    .HasColumnName("Times_RenewedExtended")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TotalAmountPastDue)
                    .HasColumnName("Total_Amount_Past_Due")
                    .HasColumnType("money");

                entity.Property(e => e.TotalCommitted)
                    .HasColumnName("Total_Committed")
                    .HasColumnType("money");

                entity.Property(e => e.TotalInterestRate)
                    .HasColumnName("Total_Interest_Rate")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.VariableRateIndex)
                    .HasColumnName("Variable_Rate_Index")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WatchList)
                    .HasColumnName("Watch_List")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect_LoanTypes>(entity =>
            {
                entity.HasKey(e => e.LoanType);

                entity.ToTable("LoanTypes", "prospect");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoanTypeDisplay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Loans>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_HistoryLoans");

                entity.ToTable("Loans", "history");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.LoanNumber)
                    .HasName("idx_loannumber");

                entity.Property(e => e.AnalystName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualGrossRevenueIncome).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AnticipatedFundingAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AnticipatedFundingDate).HasColumnType("date");

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.ApprovedLoanAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BalanceIncrease).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoreDatePulled).HasColumnType("date");

                entity.Property(e => e.CurrentWorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentWorkflowStageGate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePaidOff).HasColumnType("date");

                entity.Property(e => e.DealName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutiveSummary)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsTdr).HasColumnName("isTDR");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.LendingOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumberOrdinal)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LoanPurposeSummary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRoa)
                    .HasColumnName("LoanROA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanRoe)
                    .HasColumnName("LoanROE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDate).HasColumnType("date");

                entity.Property(e => e.ParticipationAmountPurchased).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ParticipationContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationLeadBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationPercentPurchased).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedInternalExternal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RdcdebtAmount)
                    .HasColumnName("RDCDebtAmount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelationshipRoa)
                    .HasColumnName("RelationshipROA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelationshipRoe)
                    .HasColumnName("RelationshipROE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RequestedCloseDate).HasColumnType("date");

                entity.Property(e => e.RevenueCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskGradeChangeJustification)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryLendingOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UwrequestedDate)
                    .HasColumnName("UWRequestedDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Loan_Loans>(entity =>
            {
                entity.HasKey(e => e.LoanId)
                    .HasName("PK_Loans_1");

                entity.ToTable("Loans", "loan");

                entity.HasIndex(e => e.LendingOfficer);

                entity.HasIndex(e => e.LoanNumber)
                    .HasName("idx_loannumber");

                entity.HasIndex(e => e.ProcessId);

                entity.Property(e => e.AnalystName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualGrossRevenueIncome).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AnticipatedFundingAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AnticipatedFundingDate).HasColumnType("date");

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.ApprovedLoanAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BalanceIncrease).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoreDatePulled).HasColumnType("date");

                entity.Property(e => e.CurrentWorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentWorkflowStageGate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePaidOff).HasColumnType("date");

                entity.Property(e => e.DealName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutiveSummary)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsMasterGuidanceline).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRenewal).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSubGuidanceline).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTdr).HasColumnName("IsTDR");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.LendingOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumberOrdinal)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LoanPurposeSummary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRoa)
                    .HasColumnName("LoanROA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanRoe)
                    .HasColumnName("LoanROE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDate).HasColumnType("date");

                entity.Property(e => e.ParticipationAmountPurchased).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ParticipationContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationLeadBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipationPercentPurchased).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedInternalExternal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RdcdebtAmount)
                    .HasColumnName("RDCDebtAmount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelationshipRoa)
                    .HasColumnName("RelationshipROA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelationshipRoe)
                    .HasColumnName("RelationshipROE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RequestedCloseDate).HasColumnType("date");

                entity.Property(e => e.RevenueCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskGradeChangeJustification)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryLendingOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendToUnderwriting).HasDefaultValueSql("((0))");

                entity.Property(e => e.UwrequestedDate)
                    .HasColumnName("UWRequestedDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Prospect_Loans>(entity =>
            {
                entity.HasKey(e => e.ProspectLoanId);

                entity.ToTable("Loans", "prospect");

                entity.HasIndex(e => e.ProspectId)
                    .HasName("idx_prospectid");

                entity.Property(e => e.DealDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DealName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedClosingDate).HasColumnType("date");

                entity.Property(e => e.InitialFundingAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LoanStartDate).HasColumnType("date");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StageGate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawDate).HasColumnType("date");

                entity.Property(e => e.WithdrawDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_MultipleLoans>(entity =>
            {
                entity.ToTable("MultipleLoans", "document");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoanNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_MultipleTaxIds>(entity =>
            {
                entity.ToTable("MultipleTaxIDs", "document");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxIdSsn)
                    .IsRequired()
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_NAICSCodes>(entity =>
            {
                entity.HasKey(e => e.Naicscode);

                entity.ToTable("NAICSCodes");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Naicsdescription)
                    .IsRequired()
                    .HasColumnName("NAICSDescription")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_NotesComments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NotesComments", "history");

                entity.Property(e => e.CommentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.CommentUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoteComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_NotesComments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("NotesComments", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.CommentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.CommentUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoteComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_NotesComments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__NotesCom__C3B4DFCADF396727");

                entity.ToTable("NotesComments", "tms");

                entity.Property(e => e.CommentId).ValueGeneratedNever();

                entity.Property(e => e.CommentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.CommentUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoteComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Obligors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Obligors", "history");

                entity.HasIndex(e => e.HistoryId)
                    .HasName("idx_historyid");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.AnnualIncome).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BeneficialOwnerDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BurnoutDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Caporder).HasColumnName("CAPOrder");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityTypeType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantyTypeDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObligorType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OwnershipAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OwnershipType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Pep).HasColumnName("PEP");

                entity.Property(e => e.PhysicalAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryOccupation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssntype)
                    .HasColumnName("TaxIDSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Obligors>(entity =>
            {
                entity.HasKey(e => e.ObligorId);

                entity.ToTable("Obligors", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.HasIndex(e => e.TaxIdssn);

                entity.Property(e => e.AnnualIncome).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BeneficialOwnerDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BurnoutDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Caporder).HasColumnName("CAPOrder");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityTypeType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantyTypeDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObligorType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OwnershipAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OwnershipType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Pep).HasColumnName("PEP");

                entity.Property(e => e.PhysicalAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryOccupation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssntype)
                    .HasColumnName("TaxIDSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_OnboardingACHInformation>(entity =>
            {
                entity.HasKey(e => e.OnboardingAchid)
                    .HasName("PK_OnboardingACHInformation");

                entity.ToTable("OnboardingACHInformation", "tms");

                entity.Property(e => e.AchcompanyId)
                    .HasColumnName("ACHCompanyID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AchcompanyName)
                    .HasColumnName("ACHCompanyName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DailyAchcredits)
                    .HasColumnName("DailyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DailyAchdebits)
                    .HasColumnName("DailyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MonthlyAchcredits)
                    .HasColumnName("MonthlyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MonthlyAchdebits)
                    .HasColumnName("MonthlyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OnboardingAchid)
                    .HasColumnName("OnboardingACHId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaxIdSsn)
                    .IsRequired()
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_OnboardingClientInformation>(entity =>
            {
                entity.HasKey(e => e.OnboardingId)
                    .HasName("PK__tmp_ms_x__43F2373E701AC55A");

                entity.ToTable("OnboardingClientInformation", "tms");

                entity.Property(e => e.Achstatus)
                    .HasColumnName("ACHStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rdcstatus)
                    .HasColumnName("RDCStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tmanalyst)
                    .HasColumnName("TMAnalyst")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tmsales)
                    .HasColumnName("TMSales")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Tms_OnboardingDebts>(entity =>
            {
                entity.HasKey(e => e.DebtId)
                    .HasName("PK_OnboardingDebts");

                entity.ToTable("OnboardingDebts", "tms");

                entity.Property(e => e.DebtId).ValueGeneratedOnAdd();

                entity.Property(e => e.DirectCommittedAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NewRequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OfficerLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedCommittedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Tms_OnboardingDeposits>(entity =>
            {
                entity.HasKey(e => e.DepositId)
                    .HasName("PK_OnboardingDeposits");

                entity.ToTable("OnboardingDeposits", "tms");

                entity.Property(e => e.DepositId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepositType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Tms_OnboardingRDCInformation>(entity =>
            {
                entity.HasKey(e => e.OnboardingRdcid)
                    .HasName("PK_OnboardingRDCInformation");

                entity.ToTable("OnboardingRDCInformation", "tms");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AggChargeback).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ChargebackCount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.HighestSettlement).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OnboardingRdcid)
                    .HasColumnName("OnboardingRDCId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RdcdailyLimit)
                    .HasColumnName("RDCDailyLimit")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RdcriskRate)
                    .HasColumnName("RDCRiskRate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RdcweightedRiskExposure)
                    .HasColumnName("RDCWeightedRiskExposure")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_PaymentStream>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentStream", "history");

                entity.Property(e => e.EscrowAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfPayments)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Structure)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_PaymentStream>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentStream", "loan");

                entity.Property(e => e.EscrowAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfPayments)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PaymentStreamId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Structure)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_PolicyExceptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PolicyExceptions", "history");

                entity.Property(e => e.ExceptionDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionFactors)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_PolicyExceptions>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("PolicyExceptions", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.ExceptionDetail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionFactors)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect_PotentialDeposits>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("PotentialDeposits", "prospect");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_PreparedByLookup>(entity =>
            {
                entity.HasKey(e => e.PreparedByValue);

                entity.Property(e => e.PreparedByValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedByDisplay)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_PrepaymentPenalties>(entity =>
            {
                entity.HasKey(e => e.PrepaymentValue);

                entity.ToTable("PrepaymentPenalties", "loan");

                entity.Property(e => e.PrepaymentValue)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentDisplay)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_ProductCodes>(entity =>
            {
                entity.HasKey(e => e.ProductCode);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prospect_Prospects>(entity =>
            {
                entity.HasKey(e => e.ProspectId);

                entity.ToTable("Prospects", "prospect");

                entity.HasIndex(e => e.TaxIdssn)
                    .HasName("idx_taxidssn");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.LendingOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssntype)
                    .HasColumnName("TaxIDSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_PurposeCodes>(entity =>
            {
                entity.HasKey(e => e.PurposeCode);

                entity.Property(e => e.PurposeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_RateCodes>(entity =>
            {
                entity.HasKey(e => e.RateCode);

                entity.Property(e => e.RateCode).ValueGeneratedNever();

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RateDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_Rates>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rates", "history");

                entity.Property(e => e.CeilingRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FloorRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Margin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateIndex)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Rates>(entity =>
            {
                entity.HasKey(e => e.RateId);

                entity.ToTable("Rates", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.CeilingRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FloorRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Margin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateIndex)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tms_RDCInformation>(entity =>
            {
                entity.HasKey(e => e.Rdcid);

                entity.ToTable("RDCInformation", "tms");

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("idx_ClientNumber");

                entity.Property(e => e.Rdcid).HasColumnName("RDCId");

                entity.Property(e => e.AggChargeback).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChargebackCount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.HighestChargeback).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.HighestSettlement).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightedApprovalLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Prospect_RelationshipEnhancementOpportunities>(entity =>
            {
                entity.HasKey(e => e.Reoid);

                entity.ToTable("RelationshipEnhancementOpportunities", "prospect");

                entity.Property(e => e.Reoid).HasColumnName("REOId");

                entity.Property(e => e.BusinessUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunitySummary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TargetCallDate).HasColumnType("date");
            });

            modelBuilder.Entity<Prospect_RelationshipEnhancementOpportunitiesNotes>(entity =>
            {
                entity.HasKey(e => e.ReonoteId);

                entity.ToTable("RelationshipEnhancementOpportunitiesNotes", "prospect");

                entity.Property(e => e.ReonoteId).HasColumnName("REONoteId");

                entity.Property(e => e.BusinessUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NoteTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NoteUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_RelationshipManagers>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityLevel).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAuthority).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<History_Repayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Repayment", "history");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amortization)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AutoDebit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Escrow)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstPaymentDate).HasColumnType("date");

                entity.Property(e => e.InterestCalculationMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.NumberOfPayments)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPaymentInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentChangeFrequency)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentsDue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOther)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepaymentComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RepaymentProgram)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Structure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Term)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TermUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TertiarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_Repayment>(entity =>
            {
                entity.HasKey(e => e.RepaymentId);

                entity.ToTable("Repayment", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amortization)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AutoDebit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Escrow)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstPaymentDate).HasColumnType("date");

                entity.Property(e => e.InterestCalculationMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.NumberOfPayments)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPaymentInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentChangeFrequency)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentsDue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOther)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepaymentComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RepaymentProgram)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Structure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Term)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TermUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TertiarySourceRepayment)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_RequestTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestTypes", "loan");

                entity.Property(e => e.RequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTypeDisplay)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_RequiredDocumentsByCollateralCode>(entity =>
            {
                entity.HasKey(e => new { e.DocumentName, e.CollateralCode });

                entity.ToTable("RequiredDocumentsByCollateralCode", "document");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollateralCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_RequiredDocumentsByEntityType>(entity =>
            {
                entity.HasKey(e => new { e.DocumentName, e.EntityType });

                entity.ToTable("RequiredDocumentsByEntityType", "document");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_RequiredDocumentsByPurposeCode>(entity =>
            {
                entity.HasKey(e => new { e.DocumentName, e.PurposeCode });

                entity.ToTable("RequiredDocumentsByPurposeCode", "document");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_RequiredDocumentsByStageGate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequiredDocumentsByStageGate", "document");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStageGate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbo_RiskCodes>(entity =>
            {
                entity.HasKey(e => e.RiskCode);

                entity.Property(e => e.RiskCode).ValueGeneratedNever();

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_RiskRatingChanges>(entity =>
            {
                entity.HasKey(e => e.RiskRatingChangeId);

                entity.ToTable("RiskRatingChanges", "loan");

                entity.HasIndex(e => e.LoanId);

                entity.HasIndex(e => e.ProcessId);

                entity.Property(e => e.ChangeExplanation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.RiskRatingChanges)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiskRatingChanges_Loans");
            });

            modelBuilder.Entity<Dbo_StateCodes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_StrengthWeakness>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StrengthWeakness", "history");

                entity.Property(e => e.LoanSwdescription)
                    .HasColumnName("LoanSWDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSwid).HasColumnName("LoanSWId");

                entity.Property(e => e.StrengthOrWeakness)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_StrengthWeakness>(entity =>
            {
                entity.HasKey(e => e.LoanSwid)
                    .HasName("PK_LoanSWId");

                entity.ToTable("StrengthWeakness", "loan");

                entity.Property(e => e.LoanSwid).HasColumnName("LoanSWId");

                entity.Property(e => e.LoanSwdescription)
                    .HasColumnName("LoanSWDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrengthOrWeakness)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_SubGuidanceLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubGuidanceLine", "history");

                entity.Property(e => e.MasterLoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubOrdinal)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_SubGuidanceLine>(entity =>
            {
                entity.HasKey(e => e.SubGuidanceLineId);

                entity.ToTable("SubGuidanceLine", "loan");

                entity.HasIndex(e => e.LoanId)
                    .HasName("idx_loanid");

                entity.Property(e => e.MasterLoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubOrdinal)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History_SubjectTo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubjectTo", "history");

                entity.Property(e => e.SubjectToDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_SubjectTo>(entity =>
            {
                entity.HasKey(e => e.SubjectToId);

                entity.ToTable("SubjectTo", "loan");

                entity.Property(e => e.SubjectToDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daily_TaxID_To_RespCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaxID_To_RespCode", "daily");

                entity.HasIndex(e => new { e.RespCode, e.TaxIdNumber })
                    .HasName("IX_daily_TaxId");

                entity.Property(e => e.Portfolio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RespCode)
                    .IsRequired()
                    .HasColumnName("Resp_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdNumber)
                    .IsRequired()
                    .HasColumnName("Tax_ID_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document_Taxonomy>(entity =>
            {
                entity.HasKey(e => new { e.DocumentName, e.DocumentClassification });

                entity.ToTable("Taxonomy", "document");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryIndexingRoute)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0=No SI, 1=Commercial, 2=BSA, 3=TMS");
            });

            modelBuilder.Entity<Daily_Tm_Client>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tm_client", "daily");

                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.CountryCode).HasColumnName("Country_Code");

                entity.Property(e => e.DateOpened)
                    .HasColumnName("Date_Opened")
                    .HasColumnType("datetime");

                entity.Property(e => e.NaicsCode)
                    .HasColumnName("NAICS_Code")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.NameId)
                    .HasColumnName("Name_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OfficerName).HasColumnName("Officer_Name");

                entity.Property(e => e.RespCode).HasColumnName("Resp_Code");

                entity.Property(e => e.TaxIdNumber)
                    .HasColumnName("Tax_ID_Number")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.YearsInBusiness).HasColumnName("Years_In_Business");
            });

            modelBuilder.Entity<History_TmsACHInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmsACHInformation", "history");

                entity.Property(e => e.AchcompanyId)
                    .HasColumnName("ACHCompanyID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Achid).HasColumnName("ACHId");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateBalance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.DailyAchcredits)
                    .HasColumnName("DailyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DailyAchdebits)
                    .HasColumnName("DailyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DemandBalance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.MonthlyAchcredits)
                    .HasColumnName("MonthlyACHCredits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MonthlyAchdebits)
                    .HasColumnName("MonthlyACHDebits")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .IsRequired()
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TIN')");

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<History_TmsClientInformation>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_HistoryId");

                entity.ToTable("tmsClientInformation", "history");

                entity.Property(e => e.Achstatus)
                    .HasColumnName("ACHStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rdcstatus)
                    .HasColumnName("RDCStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsn)
                    .HasColumnName("TaxIdSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdSsntype)
                    .HasColumnName("TaxIdSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<History_TmsDebts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmsDebts", "history");

                entity.Property(e => e.DirectCommittedAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NewRequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OfficerLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedCommittedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<History_TmsDeposits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmsDeposits", "history");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<History_TmsRDCInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmsRDCInformation", "history");

                entity.Property(e => e.AggChargeback).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BusinessDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChargebackCount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSince).HasColumnType("date");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.HighestChargeback).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.HighestSettlement).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LastSavedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastSavedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Naicscode)
                    .HasColumnName("NAICSCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextReviewDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortfolioNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rdcid).HasColumnName("RDCId");

                entity.Property(e => e.RiskRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightedApprovalLimit).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.YearsInBusiness).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Document_UploadedDocuments>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("UploadedDocuments", "document");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("DocumentURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAchrdcportfolio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwACHRDCPortfolio", "tms");

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAchrdcrenewals>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwACHRDCRenewals", "tms");

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCustomerCreditDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCustomerCreditDocuments", "document");

                entity.Property(e => e.DocumentClassification)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDocumentIdentifiers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDocumentIdentifiers", "document");

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwKlcreditDocumentIdentifier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwKLCreditDocumentIdentifier", "document");

                entity.Property(e => e.ComboField)
                    .HasMaxLength(112)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwKldocumentIdentifier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwKLDocumentIdentifier", "document");

                entity.Property(e => e.ComboField)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanCollateralDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanCollateralDocuments", "document");

                entity.Property(e => e.DocumentClassification)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOreoextract>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwOREOExtract", "daily");

                entity.Property(e => e.AccountingGroup).HasColumnName("Accounting_Group");

                entity.Property(e => e.AccountingGroupDesc).HasColumnName("Accounting_Group_Desc");

                entity.Property(e => e.AlllSegmentation).HasColumnName("ALLL_Segmentation");

                entity.Property(e => e.AmortizationDays).HasColumnName("Amortization_Days");

                entity.Property(e => e.AmountLastPayment).HasColumnName("Amount_Last_Payment");

                entity.Property(e => e.AvailableCredit).HasColumnName("Available_Credit");

                entity.Property(e => e.BookBalance).HasColumnName("Book_Balance");

                entity.Property(e => e.BorrowersAddress).HasColumnName("Borrowers_Address");

                entity.Property(e => e.CallReportCode).HasColumnName("Call_Report_Code");

                entity.Property(e => e.CeilingRate).HasColumnName("Ceiling_Rate");

                entity.Property(e => e.ClassCode).HasColumnName("Class_Code");

                entity.Property(e => e.CollateralAddress).HasColumnName("Collateral_Address");

                entity.Property(e => e.CollateralCode).HasColumnName("Collateral_Code");

                entity.Property(e => e.CollateralCodeDesc).HasColumnName("Collateral_Code_Desc");

                entity.Property(e => e.CurrYtdInterest).HasColumnName("Curr_YTD_Interest");

                entity.Property(e => e.CurrentBalance).HasColumnName("Current_Balance");

                entity.Property(e => e.CurrentInterestMethod).HasColumnName("Current_Interest_Method");

                entity.Property(e => e.DateLastPayment).HasColumnName("Date_Last_Payment");

                entity.Property(e => e.FairValuePremiumDiscount).HasColumnName("Fair_Value_PremiumDiscount");

                entity.Property(e => e.FasType).HasColumnName("FAS_Type");

                entity.Property(e => e.FloorRate).HasColumnName("Floor_Rate");

                entity.Property(e => e.GlSegment).HasColumnName("GL_Segment");

                entity.Property(e => e.GovernmentGuaranteed).HasColumnName("Government_Guaranteed");

                entity.Property(e => e.GuaranteedAmount).HasColumnName("Guaranteed_Amount");

                entity.Property(e => e.GuaranteedPercent).HasColumnName("Guaranteed_Percent");

                entity.Property(e => e.InterestRate).HasColumnName("Interest_Rate");

                entity.Property(e => e.InterestRateType).HasColumnName("Interest_Rate_Type");

                entity.Property(e => e.LoanNumber)
                    .HasColumnName("Loan_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoanOfficer)
                    .HasColumnName("Loan_Officer")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.LoanOfficerCode)
                    .HasColumnName("Loan_Officer_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LoanRatingCode1).HasColumnName("Loan_Rating_Code1");

                entity.Property(e => e.LoanRatingCode1FullDesc).HasColumnName("Loan_Rating_Code1_Full_Desc");

                entity.Property(e => e.MaturityDate).HasColumnName("Maturity_Date");

                entity.Property(e => e.MaximumDaysPastDue).HasColumnName("Maximum_Days_Past_Due");

                entity.Property(e => e.MiscellaneousCode).HasColumnName("Miscellaneous_Code");

                entity.Property(e => e.MsaCode).HasColumnName("MSA_Code");

                entity.Property(e => e.MsaCodeDesc).HasColumnName("MSA_Code_Desc");

                entity.Property(e => e.NaicsCode).HasColumnName("NAICS_Code");

                entity.Property(e => e.NaicsDescription).HasColumnName("NAICS_Description");

                entity.Property(e => e.NameId).HasColumnName("Name_ID");

                entity.Property(e => e.NetNonAccrualPaidInterest).HasColumnName("Net_Non_Accrual_Paid_Interest");

                entity.Property(e => e.NetUnearnedDeferredFees).HasColumnName("Net_Unearned_Deferred_Fees");

                entity.Property(e => e.NonAccrualDate).HasColumnName("Non_Accrual_Date");

                entity.Property(e => e.OriginalBalance)
                    .HasColumnName("Original_Balance")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OriginalNoteDate).HasColumnName("Original_Note_Date");

                entity.Property(e => e.PaymentType).HasColumnName("Payment_Type");

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductDescription).HasColumnName("Product_Description");

                entity.Property(e => e.PurchasedLoans).HasColumnName("Purchased_Loans");

                entity.Property(e => e.PurposeCode).HasColumnName("Purpose_Code");

                entity.Property(e => e.PurposeCodeDesc).HasColumnName("Purpose_Code_Desc");

                entity.Property(e => e.RateAdjuster).HasColumnName("Rate_Adjuster");

                entity.Property(e => e.RateChangePrevIndexRate).HasColumnName("Rate_Change_Prev_Index_Rate");

                entity.Property(e => e.RegPaymentPIAmount).HasColumnName("Reg_Payment_P_I_Amount");

                entity.Property(e => e.RegularPaymentFrequency).HasColumnName("Regular_Payment_Frequency");

                entity.Property(e => e.RemainingTerm).HasColumnName("Remaining_Term");

                entity.Property(e => e.RenewalBalance).HasColumnName("Renewal_Balance");

                entity.Property(e => e.RenewalDate).HasColumnName("Renewal_Date");

                entity.Property(e => e.SecondarySegmentation).HasColumnName("Secondary_Segmentation");

                entity.Property(e => e.StatusCodeFullDesc)
                    .IsRequired()
                    .HasColumnName("Status_Code_Full_Desc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdNumber).HasColumnName("Tax_Id_Number");

                entity.Property(e => e.Tdr).HasColumnName("TDR");

                entity.Property(e => e.TimesPastDue30To59Days).HasColumnName("Times_Past_Due_30_To_59_Days");

                entity.Property(e => e.TimesPastDue60To89Days).HasColumnName("Times_Past_Due_60_To_89_Days");

                entity.Property(e => e.TimesPastDueOver90Days).HasColumnName("Times_Past_Due_Over_90_Days");

                entity.Property(e => e.TimesRenewedExtended).HasColumnName("Times_RenewedExtended");

                entity.Property(e => e.TotalAmountPastDue).HasColumnName("Total_Amount_Past_Due");

                entity.Property(e => e.TotalCommitted).HasColumnName("Total_Committed");

                entity.Property(e => e.TotalInterestRate).HasColumnName("Total_Interest_Rate");

                entity.Property(e => e.VariableRateIndex).HasColumnName("Variable_Rate_Index");

                entity.Property(e => e.WatchList).HasColumnName("Watch_List");
            });

            modelBuilder.Entity<VwProspectsObligors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProspectsObligors", "document");

                entity.Property(e => e.PrimaryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssn)
                    .HasColumnName("TaxIDSSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdssntype)
                    .HasColumnName("TaxIDSSNType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTrackingDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTrackingDocuments", "document");

                entity.Property(e => e.Ck)
                    .IsRequired()
                    .HasColumnName("CK")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("DocumentURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.NotesComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Row).HasColumnName("Row#");
            });

            modelBuilder.Entity<Dbo_WorkflowConstants>(entity =>
            {
                entity.HasKey(e => e.ConstantName);

                entity.Property(e => e.ConstantName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConstantValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan_WorkflowStages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkflowStages", "loan");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StageGateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
