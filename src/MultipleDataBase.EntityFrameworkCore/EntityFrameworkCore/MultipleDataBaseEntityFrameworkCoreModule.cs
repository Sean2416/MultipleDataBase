using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Configuration.Startup;
using Abp.EntityFrameworkCore.Configuration;

namespace MultipleDataBase.EntityFrameworkCore
{
    [DependsOn(
        typeof(MultipleDataBaseCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MultipleDataBaseEntityFrameworkCoreModule : AbpModule
    {
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            Configuration.ReplaceService<IConnectionStringResolver, MyConnectionStringResolver>();

            Configuration.Modules.AbpEfCore().AddDbContext<MultipleDataBaseDbContext>(options =>
            {
                if (options.ExistingConnection != null)
                {
                    DbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                }
                else
                {
                    DbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                }
            });

            Configuration.Modules.AbpEfCore().AddDbContext<SecondDbContext>(options =>
            {
                if (options.ExistingConnection != null)
                {
                    SecondDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                }
                else
                {
                    SecondDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                }
            });
        }


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MultipleDataBaseEntityFrameworkCoreModule).GetAssembly());
        }
    }
}