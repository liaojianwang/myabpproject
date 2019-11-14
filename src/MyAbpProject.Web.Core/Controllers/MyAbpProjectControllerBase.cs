using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyAbpProject.Controllers
{
    public abstract class MyAbpProjectControllerBase: AbpController
    {
        protected MyAbpProjectControllerBase()
        {
            LocalizationSourceName = MyAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
