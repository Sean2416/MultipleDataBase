using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MultipleDataBase.Web.Startup;
namespace MultipleDataBase.Web.Tests
{
    [DependsOn(
        typeof(MultipleDataBaseWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MultipleDataBaseWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseWebTestModule).GetAssembly());
        }
    }
}