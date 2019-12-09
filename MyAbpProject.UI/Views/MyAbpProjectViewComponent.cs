using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyAbpProject.Web.Views
{
    public abstract class MyAbpProjectViewComponent : AbpViewComponent
    {
        protected MyAbpProjectViewComponent()
        {
            LocalizationSourceName = MyAbpProjectConsts.LocalizationSourceName;
        }
    }
}
