using Abp.Modules;
using Abp.Quartz;
using Abp.Reflection.Extensions;
using MultipleDataBase.Localization;
using Quartz;

namespace MultipleDataBase
{
    [DependsOn(
       typeof(AbpQuartzModule)
       )]
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

        public override void PostInitialize()
        {
            var jobManager = IocManager.Resolve<IQuartzScheduleJobManager>();

            jobManager.ScheduleAsync<DBCopySchedule>(
            job =>
            {
                job.WithIdentity("MonthlyReportSchedule", "MyGroup")
                    .WithDescription("A job to Create Monthly Report And Send Mail");
            },
            trigger =>
            {
                trigger.StartNow()
                    .WithSimpleSchedule(schedule =>
                    {
                        schedule.RepeatForever()
                            .WithIntervalInSeconds(10)
                            .Build();
                    });
            });

        }
    }
}