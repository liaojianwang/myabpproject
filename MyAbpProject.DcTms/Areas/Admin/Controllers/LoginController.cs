using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Domain.Uow;
using Abp.Extensions;
using Abp.MultiTenancy;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.AdminLogin;
using MyAbpProject.AdminLogin.Dtos;
using MyAbpProject.Authorization;
using MyAbpProject.Authorization.Users;
using MyAbpProject.Controllers;
using MyAbpProject.Identity;
using MyAbpProject.MultiTenancy;

namespace MyAbpProject.DcTms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : MyAbpProjectControllerBase
    {
        private readonly IManagerService _manager;
        private readonly SignInManager _signInManager;
        private readonly LogInManager _logInManager;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly ITenantCache _tenantCache;
        public LoginController(IManagerService manager
            , SignInManager signInManager
            , LogInManager logInManager
            , AbpLoginResultTypeHelper abpLoginResultTypeHelper
            , ITenantCache tenantCache)
        {
            _manager = manager;
            _signInManager = signInManager;
            _logInManager = logInManager;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _tenantCache = tenantCache;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [UnitOfWork]
        public virtual async Task<JsonResult> CheckLogin(VmAdminLogin vm, string returnUrl = "", string returnUrlHash = "")
        {
            try
            {
                //returnUrl = NormalizeReturnUrl(returnUrl);
                if (!string.IsNullOrWhiteSpace(returnUrlHash))
                {
                    returnUrl = returnUrl + returnUrlHash;
                }

                var loginResult = await GetLoginResultAsync(vm.txtUserName, vm.txtPassword, GetTenancyNameOrNull());

                await _signInManager.SignInAsync(loginResult.Identity, vm.RememberMe);
                await UnitOfWorkManager.Current.SaveChangesAsync();

                //return Json(new AjaxResponse { TargetUrl = returnUrl });

                //var loginResult = await _manager.CheckLogin(vm);
                //if (null == loginResult)
                //{
                //    return ResponseFail("系统繁忙，请稍后重试！");
                //}
                //if (loginResult.Success)
                //{
                    //await _signInManager.SignOutAndSignInAsync(loginResult.Identity, true);
                    return ResponseSucc("登录成功", new { returnUrl = returnUrl });
                //}
                //return ResponseFail(loginResult.Message);
            }
            catch (Exception ex)
            {
                return ResponseException();
            }
        }
        
        private async Task<AbpLoginResult<Tenant, User>> GetLoginResultAsync(string usernameOrEmailAddress, string password, string tenancyName)
        {
            var loginResult = await _logInManager.LoginAsync(usernameOrEmailAddress, password, tenancyName);

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, tenancyName);
            }
        }
        private string NormalizeReturnUrl(string returnUrl, Func<string> defaultValueBuilder = null)
        {
            if (defaultValueBuilder == null)
            {
                defaultValueBuilder = GetAppHomeUrl;
            }

            if (returnUrl.IsNullOrEmpty())
            {
                return defaultValueBuilder();
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return returnUrl;
            }

            return defaultValueBuilder();
        }
        public string GetAppHomeUrl()
        {
            return Url.Action("Index", "Home", new { areas = "Admin" });
        }
        private string GetTenancyNameOrNull()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return _tenantCache.GetOrNull(AbpSession.TenantId.Value)?.TenancyName;
        }
    }
}