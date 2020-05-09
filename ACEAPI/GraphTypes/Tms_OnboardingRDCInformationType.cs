using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.Models;

namespace ACEAPI.GraphTypes
{
    public class Tms_OnboardingRDCInformationType
        : ObjectType<Tms_OnboardingRDCInformation>
    {
        protected override void Configure(IObjectTypeDescriptor<Tms_OnboardingRDCInformation> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Tms_OnboardingRDCInformation");

            descriptor.Field(f => f.OnboardingRdcid)
                .Type<NonNullType<IdType>>();

            descriptor.Field(f => f.OnboardingId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(f => f.AccountNumber)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.AccountName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Status)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.HighestSettlement)
                .Type<DecimalType>();

            descriptor.Field(f => f.AggChargeback)
                .Type<DecimalType>();

            descriptor.Field(f => f.ChargebackCount)
                .Type<DecimalType>();

            descriptor.Field(f => f.RdcweightedRiskExposure)
                .Type<DecimalType>();

            descriptor.Field(f => f.RdcdailyLimit)
                .Type<DecimalType>();

            descriptor.Field(f => f.RdcriskRate)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.NotesComments)
                .Type<NonNullType<StringType>>();
        }
    }
}
