using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ACEAPI.Data;
using ACEAPI.Models;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace ACEAPI.Graph
{
    public class Mutation
    {
        private readonly aceContext _ace;

        public Mutation(aceContext ace)
        {
            _ace = ace
                ?? throw new ArgumentNullException(nameof(ace));
        }



        public async Task<Tms_OnboardingACHInformation> CreateTms_OnboardingACHInformation(
            Tms_OnboardingACHInformation onboardingACHInformation)
        {
            _ace.OnboardingAchinformation.Add(onboardingACHInformation);
            await _ace.SaveChangesAsync();

            return onboardingACHInformation;
        }

        public async Task<Tms_OnboardingACHInformation> UpdateTms_OnboardingACHInformation(
            int onboardingAchId, Tms_OnboardingACHInformation onboardingACHInformation)
        {
            if (onboardingAchId != onboardingACHInformation.OnboardingAchid)
            {
                throw new Exception("onboardingAchId does not match the OnboardingAchid of onboardingACHInformation");
            }

            _ace.Entry(onboardingACHInformation).State = EntityState.Modified;

            try
            {
                await _ace.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_OnboardingACHInformationExists(onboardingAchId))
                {
                    throw new Exception("onboardingAchId not found");
                }
                else
                {
                    throw;
                }
            }

            return onboardingACHInformation;
        }

        private bool Tms_OnboardingACHInformationExists(int onboardingAchId)
        {
            return _ace.OnboardingAchinformation.Any(x => x.OnboardingAchid == onboardingAchId);
        }



        public async Task<Tms_OnboardingDebts> CreateTms_OnboardingDebts(
            Tms_OnboardingDebts onboardingDebts)
        {
            _ace.OnboardingDebts.Add(onboardingDebts);
            await _ace.SaveChangesAsync();

            return onboardingDebts;
        }
    }
}
