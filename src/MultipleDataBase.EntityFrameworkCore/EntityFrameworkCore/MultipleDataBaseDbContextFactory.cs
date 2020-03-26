using MultipleDataBase.Configuration;
using MultipleDataBase.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MultipleDataBase.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MultipleDataBaseDbContextFactory : IDesignTimeDbContextFactory<MultipleDataBaseDbContext>
    {
        public MultipleDataBaseDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MultipleDataBaseDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MultipleDataBaseConsts.ConnectionStringName)
            );

            return new MultipleDataBaseDbContext(builder.Options);
        }
    }
}