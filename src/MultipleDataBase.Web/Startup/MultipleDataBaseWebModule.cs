using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MultipleDataBase.Configuration;
using MultipleDataBase.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MultipleDataBase.Web.Startup
{
    [DependsOn(
        typeof(MultipleDataBaseApplicationModule), 
        typeof(MultipleDataBaseEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MultipleDataBaseWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MultipleDataBaseWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MultipleDataBaseConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MultipleDataBaseNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MultipleDataBaseApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MultipleDataBaseWebModule).Assembly);
        }
    }
}