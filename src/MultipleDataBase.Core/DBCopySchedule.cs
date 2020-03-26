using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Quartz;
using MultipleDataBase.FirstDbEntities;
using Quartz;

namespace MultipleDataBase
{
    public class DBCopySchedule : JobBase, ITransientDependency
    {
        private readonly IRepository<Flow> _ReportRepository;
        private readonly IRepository<FlowLog> _LogRepository;

        public DBCopySchedule(
            IRepository<Flow> ReportRepository,
            IRepository<FlowLog> logRepository
            )
        {
            _ReportRepository = ReportRepository;
            _LogRepository = logRepository;
        }

        [UnitOfWork]
        public override Task Execute(IJobExecutionContext context)
        {
            try
            {
                Console.WriteLine("Executed MyLogJob..!");
                CreateFlowLog(GetLogData());
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Comes From Mail Service : {ex.Message}");
                throw new JobExecutionException("Something awful happened", ex, false);
            }
        }

        private List<FlowLog> GetLogData()
        {
            var flowList = _LogRepository.GetAll().ToList();
            
            Console.WriteLine(flowList);

            return flowList;
        }

        private void CreateFlowLog(List<FlowLog> flowList)
        {
            try
            {              
                foreach (var flow in flowList)
                    _ReportRepository.Insert(new Flow(flow));

                flowList.First().Proto = 888;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Comes From Mail Service : {ex.Message}");
            }
        }
    }
}
