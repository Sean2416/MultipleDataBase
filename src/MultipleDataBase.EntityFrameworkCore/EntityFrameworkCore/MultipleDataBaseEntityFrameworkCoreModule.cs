using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MultipleDataBase.EntityFrameworkCore
{
    [DependsOn(
        typeof(MultipleDataBaseCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MultipleDataBaseEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseEntityFrameworkCoreModule).GetAssembly());
        }
    }
}