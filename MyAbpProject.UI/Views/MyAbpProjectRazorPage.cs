using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MyAbpProject.Web.Views
{
    public abstract class MyAbpProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyAbpProjectRazorPage()
        {
            LocalizationSourceName = MyAbpProjectConsts.LocalizationSourceName;
        }
    }
}
