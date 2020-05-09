using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.Models;

namespace ACEAPI.GraphTypes
{
    public class Tms_OnboardingACHInformationType
        : ObjectType<Tms_OnboardingACHInformation>
    {
        protected override void Configure(IObjectTypeDescriptor<Tms_OnboardingACHInformation> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Tms_OnboardingACHInformation");

            descriptor.Field(f => f.OnboardingAchid)
                .Type<NonNullType<IdType>>();

            descriptor.Field(f => f.OnboardingId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(f => f.AchcompanyName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.TaxIdSsn)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.TaxIdSsntype)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.DailyAchcredits)
                .Type<DecimalType>();

            descriptor.Field(f => f.DailyAchdebits)
                .Type<DecimalType>();

            descriptor.Field(f => f.MonthlyAchcredits)
                .Type<DecimalType>();

            descriptor.Field(f => f.MonthlyAchdebits)
                .Type<DecimalType>();

            descriptor.Field(f => f.NotesComments)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.IsPrimary)
                .Type<BooleanType>();

            descriptor.Field(f => f.AchcompanyId)
                .Type<NonNullType<StringType>>();
        }
    }
}
