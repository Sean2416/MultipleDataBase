using Abp.AspNetCore.Mvc.Controllers;

namespace MultipleDataBase.Web.Controllers
{
    public abstract class MultipleDataBaseControllerBase: AbpController
    {
        protected MultipleDataBaseControllerBase()
        {
            LocalizationSourceName = MultipleDataBaseConsts.LocalizationSourceName;
        }
    }
}