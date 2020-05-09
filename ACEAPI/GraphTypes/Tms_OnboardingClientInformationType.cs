using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.Models;

namespace ACEAPI.GraphTypes
{
    public class Tms_OnboardingClientInformationType
        : ObjectType<Tms_OnboardingClientInformation>
    {
        protected override void Configure(IObjectTypeDescriptor<Tms_OnboardingClientInformation> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Tms_OnboardingClientInformation");

            descriptor.Field(f => f.OnboardingId)
                .Type<NonNullType<IdType>>();

            descriptor.Field(f => f.ClientNumber)
                .Type<IntType>();

            descriptor.Field(f => f.TaxIdSsn)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.TaxIdSsntype)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.ClientName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.OfficerName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.EffectiveDate)
                .Type<DateTimeType>();

            descriptor.Field(f => f.NextReviewDate)
                .Type<DateTimeType>();

            descriptor.Field(f => f.RiskRate)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.CustomerSince)
                .Type<DateTimeType>();

            descriptor.Field(f => f.YearsInBusiness)
                .Type<DecimalType>();

            descriptor.Field(f => f.PortfolioNumber)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.BusinessDescription)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Address1)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Address2)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.AddressCity)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.AddressState)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.AddressPostalCode)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.AddressCountry)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Naicscode)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Achstatus)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Rdcstatus)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.NotesComments)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.LastSavedBy)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.LastSavedTimestamp)
                .Type<DateTimeType>();

            descriptor.Field(f => f.ProcessId)
                .Type<IntType>();

            descriptor.Field(f => f.Tmanalyst)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Tmsales)
                .Type<NonNullType<StringType>>();
        }
    }
}
