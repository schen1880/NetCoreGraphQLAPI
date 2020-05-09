using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ACEAPI.Data;
using ACEAPI.Models;
using HotChocolate.AspNetCore.Authorization;

namespace ACEAPI.Graph
{
    public class Query
    {
        private readonly aceContext _ace;

        public Query(aceContext ace)
        {
            _ace = ace
                ?? throw new ArgumentNullException(nameof(ace));
        }


        
        public Tms_OnboardingACHInformation Tms_OnboardingACHInformationGetByOnboardingAchId(int onboardingAchId)
        {
            return _ace.OnboardingAchinformation.Where(x => x.OnboardingAchid == onboardingAchId).FirstOrDefault();
        }

        public IEnumerable<Tms_OnboardingACHInformation> Tms_OnboardingACHInformationGetByOnboardingId(int onboardingId)
        {
            return _ace.OnboardingAchinformation.Where(x => x.OnboardingId == onboardingId).ToList<Tms_OnboardingACHInformation>();
        }

        public IEnumerable<Tms_OnboardingACHInformation> Tms_OnboardingACHInformationGetAll()
        {
            return _ace.OnboardingAchinformation.ToList<Tms_OnboardingACHInformation>();
        }



        public Tms_OnboardingClientInformation Tms_OnboardingClientInformationGetByOnboardingId(int onboardingId)
        {
            return _ace.OnboardingClientInformation.Where(x => x.OnboardingId == onboardingId).FirstOrDefault();
        }

        public IEnumerable<Tms_OnboardingClientInformation> Tms_OnboardingClientInformationGetAll()
        {
            return _ace.OnboardingClientInformation.ToList<Tms_OnboardingClientInformation>();
        }



        public Tms_OnboardingDebts Tms_OnboardingDebtsGetByDebtId(int debtId)
        {
            return _ace.OnboardingDebts.Where(x => x.DebtId == debtId).FirstOrDefault();
        }

        public IEnumerable<Tms_OnboardingDebts> Tms_OnboardingDebtsGetByOnboardingId(int onboardingId)
        {
            return _ace.OnboardingDebts.Where(x => x.OnboardingId == onboardingId).ToList<Tms_OnboardingDebts>();
        }

        public IEnumerable<Tms_OnboardingDebts> Tms_OnboardingDebtsGetAll()
        {
            return _ace.OnboardingDebts.ToList<Tms_OnboardingDebts>();
        }



        public Tms_OnboardingDeposits Tms_OnboardingDepositsGetByDepositId(int depositId)
        {
            return _ace.OnboardingDeposits.Where(x => x.DepositId == depositId).FirstOrDefault();
        }

        public IEnumerable<Tms_OnboardingDeposits> Tms_OnboardingDepositsGetByOnboardingId(int onboardingId)
        {
            return _ace.OnboardingDeposits.Where(x => x.OnboardingId == onboardingId).ToList<Tms_OnboardingDeposits>();
        }

        public IEnumerable<Tms_OnboardingDeposits> Tms_OnboardingDepositsGetAll()
        {
            return _ace.OnboardingDeposits.ToList<Tms_OnboardingDeposits>();
        }



        public Tms_OnboardingRDCInformation Tms_OnboardingRDCInformationGetByOnboardingRdcId(int onboardingRdcId)
        {
            return _ace.OnboardingRdcinformation.Where(x => x.OnboardingRdcid == onboardingRdcId).FirstOrDefault();
        }

        public IEnumerable<Tms_OnboardingRDCInformation> Tms_OnboardingRDCInformationGetByOnboardingId(int onboardingId)
        {
            return _ace.OnboardingRdcinformation.Where(x => x.OnboardingId == onboardingId).ToList<Tms_OnboardingRDCInformation>();
        }

        public IEnumerable<Tms_OnboardingRDCInformation> Tms_OnboardingRDCInformationGetAll()
        {
            return _ace.OnboardingRdcinformation.ToList<Tms_OnboardingRDCInformation>();
        }
    }
}
