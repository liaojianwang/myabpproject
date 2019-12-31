using Abp.Application.Services;
using MyAbpProject.Navigations.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.Navigations
{
    public interface INavigationService: IApplicationService
    {
        List<NavigationOutput> GetList(long parentid, string navtype);
    }
}
