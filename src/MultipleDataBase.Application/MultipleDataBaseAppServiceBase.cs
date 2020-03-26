using Abp.Application.Services;

namespace MultipleDataBase
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MultipleDataBaseAppServiceBase : ApplicationService
    {
        protected MultipleDataBaseAppServiceBase()
        {
            LocalizationSourceName = MultipleDataBaseConsts.LocalizationSourceName;
        }
    }
}