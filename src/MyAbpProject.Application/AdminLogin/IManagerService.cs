using Abp.Application.Services;
using MyAbpProject.AdminLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject.AdminLogin
{
    public interface IManagerService : IApplicationService
    {
        Task<LoginRespose> CheckLogin(VmAdminLogin vm);
    }
}
