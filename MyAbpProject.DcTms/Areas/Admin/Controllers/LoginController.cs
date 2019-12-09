using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.AdminLogin;
using MyAbpProject.AdminLogin.Dtos;
using MyAbpProject.Controllers;
using MyAbpProject.Identity;

namespace MyAbpProject.DcTms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : MyAbpProjectControllerBase
    {
        private readonly IManagerService _manager;
        private readonly SignInManager _signInManager;
        public LoginController(IManagerService manager
            , SignInManager signInManager)
        {
            _manager = manager;
            _signInManager = signInManager;
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
                var loginResult = await _manager.CheckLogin(vm);
                if (null == loginResult)
                {
                    return ResponseFail("系统繁忙，请稍后重试！");
                }
                if (loginResult.Success)
                {
                    await _signInManager.SignOutAndSignInAsync(loginResult.Identity, true);
                    return ResponseSucc("登录成功", new { returnUrl = returnUrl });
                }
                return ResponseFail(loginResult.Message);
            }
            catch (Exception ex)
            {
                return ResponseException();
            }
        }
    }
}