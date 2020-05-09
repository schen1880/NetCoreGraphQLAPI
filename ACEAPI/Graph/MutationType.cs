using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate.Types;
using ACEAPI.GraphTypes;

namespace ACEAPI.Graph
{
    public class MutationType
        : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            base.Configure(descriptor);



            descriptor.Field(f => f.CreateTms_OnboardingACHInformation(default))
                .Type<NonNullType<Tms_OnboardingACHInformationType>>()
                .Argument("onboardingACHInformation", a => a.Type<NonNullType<Tms_OnboardingACHInformationInputType>>());

            descriptor.Field(f => f.UpdateTms_OnboardingACHInformation(default, default))
                .Type<NonNullType<Tms_OnboardingACHInformationType>>()
                .Argument("onboardingAchId", a => a.Type<NonNullType<IntType>>())
                .Argument("onboardingACHInformation", a => a.Type<NonNullType<Tms_OnboardingACHInformationInputType>>());
        }
    }
}
