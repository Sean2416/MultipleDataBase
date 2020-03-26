using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MultipleDataBase.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MultipleDataBaseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MultipleDataBaseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }

    }
}
