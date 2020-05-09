using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;

using Microsoft.Identity.Web;
using Microsoft.Identity.Web.TokenCacheProviders.InMemory;
using ACEAPI.Infrastructure;

using Microsoft.OpenApi.Models;
using ACEAPI.Data;

using HotChocolate;
using HotChocolate.AspNetCore;

using ACEAPI.Graph;
using ACEAPI.GraphTypes;
using HotChocolate.Execution.Configuration;
using HotChocolate.AspNetCore.Voyager;

namespace ACEAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(AzureADDefaults.BearerAuthenticationScheme)
            //    .AddAzureADBearer(options => Configuration.Bind("AzureAd", options));

            //services.AddMicrosoftIdentityPlatformAuthentication(Configuration)
            //   .AddMsal(Configuration, new string[] { Constants.ScopeUserRead })
            //   .AddInMemoryTokenCaches();

            services.AddProtectedWebApi(Configuration);

            services.AddControllers();

            services.AddDbContext<aceContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ACEdb")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ACE API", Version = "v1" });

                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        AuthorizationCode = new OpenApiOAuthFlow
                        {
                            //AuthorizationUrl = new Uri(Configuration["Swagger:Instance"] + Configuration["Swagger:TenantId"] + "/oauth2/v2.0/authorize", UriKind.Absolute),
                            AuthorizationUrl = new Uri($"{Configuration["Swagger:Instance"]}{Configuration["Swagger:TenantId"]}/oauth2/v2.0/authorize", UriKind.Absolute),
                            TokenUrl = new Uri($"{Configuration["Swagger:Instance"]}{Configuration["Swagger:TenantId"]}/oauth2/v2.0/token", UriKind.Absolute),
                            Scopes = new Dictionary<string, string>
                            {
                                //{ "readAccess", "Access read operations" },
                                //{ "writeAccess", "Access write operations" }
                                {"api://e3d9a8d8-1071-4973-bdd6-9f5afa42f002/user_impersonation", "Access ACEAPI" }
                            }
                        }
                    }
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                        },
                        new[] { "api://e3d9a8d8-1071-4973-bdd6-9f5afa42f002/user_impersonation" } //{ "readAccess", "writeAccess" }
                    }
                });
            });

            //graphql

            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .AddType<Tms_OnboardingACHInformationType>()
                .AddType<Tms_OnboardingClientInformationType>()
                .AddType<Tms_OnboardingDebtsType>()
                .AddType<Tms_OnboardingDepositsType>()
                .AddType<Tms_OnboardingRDCInformationType>()
                .Create(),
                new QueryExecutionOptions
                {
                    TracingPreference = TracingPreference.Always
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphQL("/graphql");
            app.UsePlayground("/graphql");
            app.UseVoyager("/graphql");

            //app.UseGraphQL();
            //app.UsePlayground();
            //app.UseVoyager();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ACE API V1");

                c.OAuthAppName("ACE API V1");
                c.OAuthClientId(Configuration["Swagger:ClientId"]);
                c.OAuthClientSecret(Configuration["Swagger:ClientSecret"]);
                c.OAuthScopeSeparator(" ");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
