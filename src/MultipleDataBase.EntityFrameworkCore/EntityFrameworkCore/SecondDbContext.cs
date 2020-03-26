using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultipleDataBase.FirstDbEntities;

namespace MultipleDataBase.EntityFrameworkCore
{
    public class SecondDbContext : AbpDbContext
    {
        public DbSet<FlowLog> FlowLogs { get; set; }

        public SecondDbContext(DbContextOptions<SecondDbContext> options) 
            : base(options)
        {

        }
    }
}
