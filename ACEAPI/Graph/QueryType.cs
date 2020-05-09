using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using ACEAPI.GraphTypes;
using HotChocolate.Types;

namespace ACEAPI.Graph
{
    public class QueryType
        : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            base.Configure(descriptor);

            //descriptor.Authorize();



            descriptor.Field(f => f.Tms_OnboardingACHInformationGetByOnboardingAchId(default))
                .Type<Tms_OnboardingACHInformationType>();

            descriptor.Field(f => f.Tms_OnboardingACHInformationGetByOnboardingId(default))
                .Type<ListType<Tms_OnboardingACHInformationType>>();

            descriptor.Field(f => f.Tms_OnboardingACHInformationGetAll())
                .Type<ListType<Tms_OnboardingACHInformationType>>();



            descriptor.Field(f => f.Tms_OnboardingClientInformationGetByOnboardingId(default))
                .Type<Tms_OnboardingClientInformationType>();

            descriptor.Field(f => f.Tms_OnboardingClientInformationGetAll())
                .Type<ListType<Tms_OnboardingClientInformationType>>();



            descriptor.Field(f => f.Tms_OnboardingDebtsGetByDebtId(default))
                .Type<Tms_OnboardingDebtsType>();

            descriptor.Field(f => f.Tms_OnboardingDebtsGetByOnboardingId(default))
                .Type<ListType<Tms_OnboardingDebtsType>>();

            descriptor.Field(f => f.Tms_OnboardingDebtsGetAll())
                .Type<ListType<Tms_OnboardingDebtsType>>();



            descriptor.Field(f => f.Tms_OnboardingDepositsGetByDepositId(default))
                .Type<Tms_OnboardingDepositsType>();

            descriptor.Field(f => f.Tms_OnboardingDepositsGetByOnboardingId(default))
                .Type<ListType<Tms_OnboardingDepositsType>>();

            descriptor.Field(f => f.Tms_OnboardingDepositsGetAll())
                .Type<ListType<Tms_OnboardingDepositsType>>();



            descriptor.Field(f => f.Tms_OnboardingRDCInformationGetByOnboardingRdcId(default))
                .Type<Tms_OnboardingRDCInformationType>();

            descriptor.Field(f => f.Tms_OnboardingRDCInformationGetByOnboardingId(default))
                .Type<ListType<Tms_OnboardingRDCInformationType>>();

            descriptor.Field(f => f.Tms_OnboardingRDCInformationGetAll())
                .Type<ListType<Tms_OnboardingRDCInformationType>>();
        }
    }
}
