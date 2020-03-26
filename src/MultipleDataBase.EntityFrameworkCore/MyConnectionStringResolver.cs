using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Microsoft.Extensions.Configuration;
using MultipleDataBase.Configuration;
using MultipleDataBase.EntityFrameworkCore;
using MultipleDataBase.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleDataBase
{
    class MyConnectionStringResolver : DefaultConnectionStringResolver
    {

        public MyConnectionStringResolver(IAbpStartupConfiguration configuration)
            : base(configuration)
        {
        }

        public override string GetNameOrConnectionString(ConnectionStringResolveArgs args)
        {
            if (args["DbContextConcreteType"] as Type == typeof(SecondDbContext))
            {
                var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
                return configuration.GetConnectionString(MultipleDataBaseConsts.MySqlConnectionStringName);
            }

            return base.GetNameOrConnectionString(args);
        }
    }
}

