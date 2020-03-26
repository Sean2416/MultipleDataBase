using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MultipleDataBase.EntityFrameworkCore;
using MultipleDataBase.Tests.TestDatas;

namespace MultipleDataBase.Tests
{
    public class MultipleDataBaseTestBase : AbpIntegratedTestBase<MultipleDataBaseTestModule>
    {
        public MultipleDataBaseTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MultipleDataBaseDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MultipleDataBaseDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MultipleDataBaseDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MultipleDataBaseDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MultipleDataBaseDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MultipleDataBaseDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MultipleDataBaseDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MultipleDataBaseDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
