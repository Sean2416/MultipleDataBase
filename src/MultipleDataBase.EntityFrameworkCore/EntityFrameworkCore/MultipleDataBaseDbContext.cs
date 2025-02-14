﻿using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultipleDataBase.FirstDbEntities;

namespace MultipleDataBase.EntityFrameworkCore
{
    public class MultipleDataBaseDbContext : AbpDbContext
    {
        public DbSet<Flow> Flows { get; set; }

        public MultipleDataBaseDbContext(DbContextOptions<MultipleDataBaseDbContext> options) 
            : base(options)
        {

        }
    }
}
