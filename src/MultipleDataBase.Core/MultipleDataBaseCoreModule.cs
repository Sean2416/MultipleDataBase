using Abp.Modules;
using Abp.Reflection.Extensions;
using MultipleDataBase.Localization;

namespace MultipleDataBase
{
    public class MultipleDataBaseCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MultipleDataBaseLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseCoreModule).GetAssembly());
        }
    }
}