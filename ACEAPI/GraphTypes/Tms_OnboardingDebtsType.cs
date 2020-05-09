using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.Models;

namespace ACEAPI.GraphTypes
{
    public class Tms_OnboardingDebtsType
        : ObjectType<Tms_OnboardingDebts>
    {
        protected override void Configure(IObjectTypeDescriptor<Tms_OnboardingDebts> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Tms_OnboardingDebts");

            descriptor.Field(f => f.DebtId)
                .Type<NonNullType<IdType>>();

            descriptor.Field(f => f.OnboardingId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(f => f.DebtTypeCode)
                .Type<ShortType>();

            descriptor.Field(f => f.DirectCommittedAmount)
                .Type<DecimalType>();

            descriptor.Field(f => f.RelatedCommittedAmount)
                .Type<DecimalType>();

            descriptor.Field(f => f.NewRequestAmount)
                .Type<DecimalType>();

            descriptor.Field(f => f.OfficerLimit)
                .Type<DecimalType>();
        }
    }
}
