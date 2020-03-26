using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MultipleDataBase
{
    [DependsOn(
        typeof(MultipleDataBaseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MultipleDataBaseApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseApplicationModule).GetAssembly());
        }
    }
}