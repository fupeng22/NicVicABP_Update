using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Abp.WebApi.Controllers.Dynamic.Clients;

namespace NicVicABP.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(NicVicABPApplicationModule))]
    public class NicVicABPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(NicVicABPApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

            //Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder.ForAll<IApplicationService>(Assembly.GetAssembly(typeof(NicVicABPApplicationModule)), "tasksystem")
            //   .Build();
        }
    }
}
