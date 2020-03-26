using Microsoft.EntityFrameworkCore;

namespace MultipleDataBase.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MultipleDataBaseDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MultipleDataBaseDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
