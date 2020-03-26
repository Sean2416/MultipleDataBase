using Abp.AspNetCore.Mvc.Views;

namespace MultipleDataBase.Web.Views
{
    public abstract class MultipleDataBaseRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MultipleDataBaseRazorPage()
        {
            LocalizationSourceName = MultipleDataBaseConsts.LocalizationSourceName;
        }
    }
}
