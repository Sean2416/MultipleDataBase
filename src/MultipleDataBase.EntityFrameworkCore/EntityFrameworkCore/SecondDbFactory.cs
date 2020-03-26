using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MultipleDataBase.Configuration;
using MultipleDataBase.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleDataBase.EntityFrameworkCore
{
    public class SecondDbFactory : IDesignTimeDbContextFactory<SecondDbContext>
    {
        public SecondDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SecondDbContext>();

            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SecondDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MultipleDataBaseConsts.MySqlConnectionStringName));

            return new SecondDbContext(builder.Options);
        }
    }
}

