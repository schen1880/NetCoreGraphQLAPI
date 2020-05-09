using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.Models;

namespace ACEAPI.GraphTypes
{
    public class Tms_OnboardingDepositsType
        : ObjectType<Tms_OnboardingDeposits>
    {
        protected override void Configure(IObjectTypeDescriptor<Tms_OnboardingDeposits> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Tms_OnboardingDeposits");

            descriptor.Field(f => f.DepositId)
                .Type<NonNullType<IdType>>();

            descriptor.Field(f => f.OnboardingId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(f => f.DepositType)
                .Type<NonNullType<StringType>>();

            descriptor.Field(f => f.DirectAmount)
                .Type<DecimalType>();

            descriptor.Field(f => f.RelatedAmount)
                .Type<DecimalType>();
        }
    }
}
