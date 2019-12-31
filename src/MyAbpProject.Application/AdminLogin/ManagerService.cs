using Abp.Dapper.Repositories;
using Abp.Extensions;
using MyAbpProject.AdminLogin.Dtos;
using MyAbpProject.CmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject.AdminLogin
{
    public class ManagerService : IManagerService
    {
        private readonly IDapperRepository<ManagerInfo, long> _manager;
        public ManagerService(IDapperRepository<ManagerInfo, long> manager)
        {
            _manager = manager;
        }

        public async Task<LoginRespose> CheckLogin(VmAdminLogin vm)
        {
            LoginRespose result = new LoginRespose() { Success = false };
            try
            {
                var list = await _manager.GetAllAsync(c => c.user_name == vm.txtUserName);
                if (null == list)
                {
                    result.Message = "账号不存在！";
                    return result;
                }
                var managers = list.ToList();
                if (managers.Count == 0)
                {
                    result.Message = "账号不存在！";
                    return result;
                }
                if (managers.Count > 1)
                {
                    result.Message = "存在多个相同账号！";
                    return result;
                }
                var model = managers.FirstOrDefault();
                if (!model.password.Equals(vm.txtPassword.ToMd5()))
                {
                    result.Message = "登录密码不正确！";
                    return result;
                }
                if (model.is_lock == 1)
                {
                    result.Message = "该账号已被锁定！";
                    return result;
                }
                var claimsIdentity = new ClaimsIdentity("ApplicationCookie");
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, model.user_name));
                var security = Guid.NewGuid().ToString();
                claimsIdentity.AddClaim(new Claim(ClaimTypes.GroupSid, "1"));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, ""));
                claimsIdentity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity"));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.System, "-1"));
                claimsIdentity.AddClaim(new Claim("AspNet.Identity.SecurityStamp", security));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, model.Id.ToString()));
                result.Success = true;
                result.Identity = claimsIdentity;
                return result;
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}
