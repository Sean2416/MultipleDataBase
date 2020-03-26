using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MultipleDataBase.EntityFrameworkCore
{
    public static class SecondDbContextConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<SecondDbContext> dbContextOptions, 
            string connectionString
            )
        {
            dbContextOptions.UseMySql(connectionString);
        }
        public static void Configure(DbContextOptionsBuilder<SecondDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
