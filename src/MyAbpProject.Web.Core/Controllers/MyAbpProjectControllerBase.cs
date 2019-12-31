using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MyAbpProject.Controllers
{
    public abstract class MyAbpProjectControllerBase : AbpController
    {
        protected MyAbpProjectControllerBase()
        {
            LocalizationSourceName = MyAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
        protected virtual JsonResult ResponseSucc(string message, object obj = null)
        {
            if (null == obj)
            {
                return Json(new { Code = 0, Msg = message });
            }
            return Json(new { Code = 0, Msg = message, Data = obj });
        }
        protected virtual JsonResult ResponseSucc(string message, params object[] obj)
        {
            return Json(new { Code = 0, Msg = message, Data = obj });
        }
        protected virtual JsonResult ResponseFail(string message, object obj = null)
        {
            return Json(new { Code = 1, Msg = message, Data = obj });
        }
        protected virtual JsonResult ResponseException(string message = "", object obj = null)
        {
            return Json(new { Code = -1, Msg = (message == "" ? "系统繁忙，请稍后重试" : message), Data = obj });
        }
    }
}
