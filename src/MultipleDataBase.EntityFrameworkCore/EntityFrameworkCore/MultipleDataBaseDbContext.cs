using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MultipleDataBase.EntityFrameworkCore
{
    public class MultipleDataBaseDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MultipleDataBaseDbContext(DbContextOptions<MultipleDataBaseDbContext> options) 
            : base(options)
        {

        }
    }
}
